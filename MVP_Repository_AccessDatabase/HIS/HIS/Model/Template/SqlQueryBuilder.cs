using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Reflection;

namespace HIS.Model
{
    public class SqlQueryBuilder<T> where T : class
    {
        private readonly T _item;
        public SqlQueryBuilder(T item)
        {
            _item = item;
        }
        #region Insert
        public OleDbCommand GetInsertCommand()
        {
            var table = GetTableName();
            if (String.IsNullOrEmpty(table))
                throw new Exception("No Table attribute was found.");
            var query = String.Format("INSERT INTO {0} ({1}) Values ({2})",
                table,
                GetInsertFieldNameList(),
                GetInsertFieldList());
            return new OleDbCommand(query);
        }
        private string GetInsertFieldNameList()
        {
            var sb = new StringBuilder();
            var properties = _item.GetType().GetProperties();
            foreach (var propertyInfo in properties)
            {
                sb.Append(String.Format("{0},", propertyInfo.Name));
            }
            var query = sb.ToString();
            return query.Remove(query.Length - 1);
        }
        private string GetInsertFieldList()
        {
            var sb = new StringBuilder();
            var properties = _item.GetType().GetProperties();
            foreach (var propertyInfo in properties)
            {
                var property = GetSqlValue(_item, propertyInfo);
                sb.Append(GetFormattedInsertField(propertyInfo, property));
            }
            var query = sb.ToString();
            return query.Remove(query.Length - 1);
        }
        private string GetFormattedInsertField(PropertyInfo propertyInfo, SqlString property)
        {
            //null
            if (property.Value == "null")
            {
                return String.Format("{0},", property.Value);
            }
            // Int
            var result = String.Format("{0},", property.Value);
            // string
            if (propertyInfo.PropertyType == typeof(string))
            {
                result = String.Format("'{0}',", property.Value);
            }
            // datetime
            else if (propertyInfo.PropertyType == typeof(DateTime))
            {
                result = String.Format("#{0:u}#,", property.Value);
            }
            return result;
        }
        #endregion
        #region Update
        public  OleDbCommand GetUpdateCommand()
        {
            var table = GetTableName();
            if (String.IsNullOrEmpty(table))
                throw new Exception("No Table attribute was found.");
            GetKeyFieldName();
            var query = String.Format("UPDATE {0} SET {1} WHERE {2}", 
                table, GetUpdateFieldList(), GetKeyFieldList());
            return new OleDbCommand(query);
        }
        private string GetKeyFieldList()
        {
            var sb = new StringBuilder();
            var properties = _item.GetType().GetProperties();
            var keyField = GetKeyFieldName();
            foreach (var propertyInfo in properties)
            {
                Boolean IsKey = false;
                foreach (var key in keyField)
                {
                    if (key == propertyInfo.Name)
                    {
                        IsKey = true;
                        break;
                    }
                }
                if (IsKey != true) continue;
                var property = GetSqlValue(_item, propertyInfo);
                sb.Append(GetFormattedKeyField(propertyInfo, property));
            }
            var query = sb.ToString();
            return query.Remove(query.Length - 4);
        }
        private string GetUpdateFieldList()
        {
            var sb = new StringBuilder();
            var properties = _item.GetType().GetProperties();
            var keyField = GetKeyFieldName();
            foreach (var propertyInfo in properties)
            {
                var property = GetSqlValue(_item, propertyInfo);
                sb.Append(GetFormattedUpdateField(propertyInfo, property));
            }
            var query = sb.ToString();
            return query.Remove(query.Length - 1);
        }
        private string GetFormattedKeyField(PropertyInfo propertyInfo, SqlString property)
        {
            //null            
            if (property.Value == "null") {
                return String.Format("{0}={1} and ", propertyInfo.Name, property.Value);
            }
            // int
            var result = String.Format("{0}={1} and ", propertyInfo.Name, property.Value);
            // string
            if (propertyInfo.PropertyType == typeof(string))
            {
                result = String.Format("{0}='{1}' and ", propertyInfo.Name, property.Value);
            }
            // datetime
            else if (propertyInfo.PropertyType == typeof(DateTime))
            {
                result = String.Format("{0}=#{1:u}# and ", propertyInfo.Name, property.Value);
            }
            return result;
            
        }
        private string GetFormattedUpdateField(PropertyInfo propertyInfo, SqlString property)
        {
            //null
            if (property.Value == "null") {
                return String.Format("{0}={1},", propertyInfo.Name, property.Value);
            }
            // int
            var result = String.Format("{0}={1},", propertyInfo.Name, property.Value);
            // string
            if (propertyInfo.PropertyType == typeof(string))
            {
                result = String.Format("{0}='{1}',", propertyInfo.Name, property.Value);
            }
            // datetime
            else if (propertyInfo.PropertyType == typeof(DateTime))
            {
                result = String.Format("{0}=#{1:u}#,", propertyInfo.Name, property.Value);
            }
            return result;
        }
        #endregion
        #region Delete
        public OleDbCommand GetDeleteCommand()
        {
            var table = GetTableName();
            if (String.IsNullOrEmpty(table))
                throw new Exception("No Table attribute was found.");
            var query = String.Format("DELETE FROM {0} WHERE {1}",
                table,
                GetKeyFieldList());
            return new OleDbCommand(query);
        }
        #endregion

        #region Helper methods
        protected string GetTableName()
        {
            var tableAttr = Attribute.GetCustomAttribute(typeof(T),
                typeof(TableAttribute));
            return tableAttr != null
                ? (tableAttr as TableAttribute).Name
                : String.Empty;
        }
        private SqlString GetSqlValue(T item, PropertyInfo propertyInfo)
        {
            try
            {
                return new SqlString(propertyInfo.GetValue(item).ToString());
            }
            catch(System.NullReferenceException)
            {
                return new SqlString("null");
            }
            //return new SqlString(propertyInfo. = null ? "null" : propertyInfo.GetValue(item).ToString());
            //return new SqlString(propertyInfo.GetValue(item).ToString());
        }
        private IEnumerable<string> GetKeyFieldName()
        {
            var result = GetKeyField();
            return from r in result select r.Name;
        }
        private IEnumerable<string> GetKeyFieldValue()
        {
            var result = GetKeyField();
            var valueList = from r in result select r.GetValue(_item);
            List<string> valueStringList = new List<string>();
            foreach (var value in valueList)
            {
                valueStringList.Add(value.ToString());
            }
            return valueStringList;
        }
        public IEnumerable<PropertyInfo> GetKeyField()
        {
            var keyField = from x in _item.
                                        GetType().
                                        GetProperties().
                                        Where(x => Attribute.IsDefined(x, typeof(KeyAttribute)))
                           select x;
            if (keyField != null)
            {
                return keyField;
            }
            throw new Exception("Key on a property could not be found");            
        }
        #endregion
    }
}
