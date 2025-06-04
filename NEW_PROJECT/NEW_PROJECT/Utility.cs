using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_PROJECT
{
    public static class Utility
    {

        // פונקציה לבדוק אם אובייקט הוא מסוג מסוים
        public static bool IsPropertyType(object obj, PropertyType type)
        {
            if (obj is Property property)
            {
                return property.Type == type;
            }
            return false;
        }

        // פונקציה הממירה אובייקט לנכס
        public static Property ConvertToProperty(object obj)
        {
            return obj as Property;
        }
    }

    // מחלקה סגורה לדוגמה
    public sealed class FileLogger
    {
        private string filePath;

        public FileLogger(string path)
        {
            filePath = path;
        }

        // פונקציה לכתיבה לקובץ
        public void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
