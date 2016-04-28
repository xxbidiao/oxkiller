using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace oxkiller.Utility
{
    public static class Debug
    {
        public static void Log(string message)
        {
            return;
        }

        public static void Log(Exception e)
        {
            return;
        }
    }

    /// <summary>
    /// JSON File management class
    /// </summary>
    public class FileManager
    {
        #region file IO
        /// <summary>
        /// Write an object to a file.
        /// </summary>
        /// <param name="obj">The object that needs to be written to storage.</param>
        /// <param name="path">The absolute path.</param>
        public bool writeFile(object obj,string path)
        {
            try
            {
                string result = new JSONManager().objectToString(obj);
                System.IO.File.WriteAllText(path, result);
                return true;
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Write an object to a file with auto-generated path.
        /// </summary>
        /// <param name="obj">The object that needs to be written to storage.</param>
        /// <param name="name">The name of the object.</param>
        /// <param name="filetype">The file type name of the object.</param>
        public bool writeFileWithGeneratedPath(object obj, string name, string filetype)
        {
            try
            {
                writeFile(obj, generateFilePath(name, filetype));
                return true;
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Read a file from storage and convert it to an object.
        /// </summary>
        /// <param name="path">The absolute path of the object.</param>
        /// <param name="type">The type of the object that is converted into.</param>
        /// <returns>The read object.</returns>
        public object readFile(string path, Type type)
        {
            try
            {
                JSONManager jm = new JSONManager();
                string result = System.IO.File.ReadAllText(path);
                MethodInfo method = typeof(JSONManager).GetMethod("stringToObject");
                MethodInfo generic = method.MakeGenericMethod(type);
                return generic.Invoke(jm, new object[] { result });
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                return null;
            }

        }

        /// <summary>
        /// Read file from storage with full auto-generated path.
        /// </summary>
        /// <param name="name">The name of the object.</param>
        /// <param name="filetype">The file type of the object.</param>
        /// <param name="type">The class type of the object.</param>
        /// <returns>The read object.</returns>
        public object readFileWithGeneratedPath(string name, string filetype, Type type)
        {
            try
            {
                return readFile(generateFilePath(name, filetype), type);
            }
            catch (Exception e)
            {
                Debug.Log(e);
                return null;
            }
        }

        /// <summary>
        /// Delete a file in the given path.
        /// Not intended for direct use.
        /// </summary>
        /// <param name="path">location of the file, with extension.</param>
        /// <returns>Whether the operation was successful.</returns>
        public bool deleteFile(string path)
        {
            try
            {
                System.IO.File.Delete(path);
                return true;
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                return false;
            }
        }

        public bool deleteFileWithGeneratedPath(string name, string filetype)
        {
            try
            {
                return deleteFile(generateFilePath(name, filetype));
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                return false;
            }
        }

        #endregion

        #region path generation
        /// <summary>
        /// Generate full path for file.
        /// </summary>
        /// <param name="name">The name of the object.</param>
        /// <param name="filetype">The file type of the object.</param>
        /// <returns>Full path of the requested file.</returns>
        public string generateFilePath(string name,string filetype)
        {
            string fpath = path;
            fpath += "/";
            fpath += name + "." + filetype;
            return fpath;
        }

        /// <summary>
        /// Default persistent file storage location.
        /// </summary>
        private string path
        {
            get
            {
                return Directory.GetCurrentDirectory();
            }
        }
        #endregion

        #region get file info
        public List<string> getAllNamesForFileType(string filetype)
        {
            try
            {
                String[] result = Directory.GetFiles(path, "*." + filetype, SearchOption.AllDirectories);
                List<string> resultL = new List<string>();
                foreach (string s in result)
                {
                    resultL.Add(Path.GetFileNameWithoutExtension(s));
                }
                return resultL;
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                return null;
            }

        }

        #endregion
    }
}
