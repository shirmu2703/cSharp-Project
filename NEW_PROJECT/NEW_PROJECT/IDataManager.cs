using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_PROJECT
{
    public interface IDataManager
    {
        void SaveToFile(string filePath);  // שמירת נתונים לקובץ
        void LoadFromFile(string filePath); // טעינת נתונים מקובץ
    }
}
