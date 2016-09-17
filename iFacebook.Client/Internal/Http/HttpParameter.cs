using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Internal.Http
{
    public class HttpParameter
    {
        private string name = null;
        private string value = null;
        private FileInfo file = null;
        private FileStream fileBody = null;
        private static long serialVersionUID = -8708108746980739212L;
        private static string JPEG = "image/jpeg";
        private static string GIF = "image/gif";
        private static string PNG = "image/png";
        private static string OCTET = "application/octet-stream";

        public HttpParameter(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        public HttpParameter(string name,FileInfo file)
        {
            this.name = name;
            this.file = file;
        }

        public HttpParameter(string name, string fileName, FileStream fileBody)
        {
            this.name = name;
            file = new FileInfo(fileName);
            this.fileBody = fileBody;
        }

        public HttpParameter(string name, int value)
        {
            this.name = name;
            this.value = value + string.Empty;
        }

        public HttpParameter(string name, long value)
        {
            this.name = name;
            this.value = value + string.Empty;
        }

        public HttpParameter(string name, double value)
        {
            this.name = name;
            this.value = value + string.Empty;
        }

        public HttpParameter(string name, bool value)
        {
            this.name = name;
            this.value = value + string.Empty;
        }

        public string getName()
        {
            return name;
        }

        public string getValue()
        {
            return value;
        }

        public FileInfo getFile()
        {
            return file;
        }

        public FileStream getFileBody()
        {
            return fileBody;
        }

        public bool isFile()
        {
            return file != null;
        }

        public bool hasFileBody()
        {
            return fileBody != null;
        }

        public string getContentType()
        {
            if (!isFile())
                throw new FileNotFoundException("not a file");
            string extension = file.Extension;
            switch (extension)
            {
                case "gif": return "image/gif";
                case "png": return "image/png";
                case "jpg": return "image/jpg";
                case "jpeg": return "image/jpeg";
                default: return "application/octet-stream";
            }
        }

        public static bool containsFile(HttpParameter[] parameters)
        {
            bool isContainsFile = false;
            if (null == parameters)
                return false;
            foreach(var param in parameters)
            {
                if (param.isFile())
                {
                    isContainsFile = true;
                    break;
                }
            }

            return isContainsFile;
        }

        private static bool containsFile(List<HttpParameter> parameters)
        {
            bool isContainsFile = false;
            foreach(var param in parameters)
            {
                if (param.isFile())
                {
                    isContainsFile = true;
                    break;
                }
            }

            return isContainsFile;
        }

        public static HttpParameter[] getParameterArray(string name, string value)
        {
            return new HttpParameter[] {
                new HttpParameter(name, value) };
        }

        public static HttpParameter[] getParameterArray(string name1, string value1, string name2, string value2)
        {
            return new HttpParameter[] {
                new HttpParameter(name1, value1),
                new HttpParameter(name2, value2) };
        }

        public static HttpParameter[] getParameterArray(string name1, int value1, string name2, int value2)
        {
            return new HttpParameter[] {
                new HttpParameter(name1, value1),
                new HttpParameter(name2, value2) };
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            if (!(obj is HttpParameter))
                return false;
            HttpParameter that = (HttpParameter)obj;
            if (file != null ? !file.Equals(that.file) : that.file != null)
                return false;
            if (fileBody != null ? !fileBody.Equals(that.fileBody) : fileBody != null)
                return false;
            if (!name.Equals(that.name))
                return false;
            if (value != null ? !value.Equals(that.value) : that.value != null)
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            int result = name.GetHashCode();
            result = 31 * result + (value != null ? value.GetHashCode() : 0);
            result = 31 * result + (file != null ? file.GetHashCode() : 0);
            result = 31 * result + (fileBody != null ? fileBody.GetHashCode() : 0);
            return result;
        }

        public override string ToString()
        {
            return string.Format("PostParameter{name='{0}', value='{1}', file={2}, fileBody={3}}", name, value, file, fileBody);
        }

        public int compareTo(object obj)
        {
            HttpParameter that = (HttpParameter)obj;
            int compared = name.CompareTo(that.name);
            if (0 == compared)
                compared = value.CompareTo(that.value);

            return compared;
        }

        public static string encodeParameter(HttpParameter[] parameters)
        {
            if (null == parameters)
                return string.Empty;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i].isFile())
                    throw new FileLoadException(string.Format("parameter [{0}] should be text", parameters[i].name));

                if (i != 0)
                    sb.Append("&");
                sb.Append(encode(parameters[i].name)).Append("=").Append(encode(parameters[i].value));
            }

            return sb.ToString();
        }

        private static string encode(string value)
        {
            string encoded = null;
            try
            {
                encoded = Uri.EscapeUriString(value);
            }
            catch (Exception ex) { }
            StringBuilder sb = new StringBuilder(encoded);
            for (int i = 0; i < encoded.Length; i++)
            {
                char focus = encoded[i];
                if (focus == '*')
                    sb.Append("%2A");
                else if (focus == '+')
                    sb.Append("%20");
                else if ((focus == '%') && (i + 1 < encoded.Length) && (encoded[i + 1] == '7') && (encoded[i + 2] == 'E'))
                {
                    sb.Append("~");
                    i += 2;
                }
                else sb.Append(focus);
            }

            return sb.ToString();
        }

        public static HttpParameter[] merge(HttpParameter[] parameters1, HttpParameter[] parameters2)
        {
            if ((parameters1 != null && parameters2 != null))
            {
                HttpParameter[] parameters = new HttpParameter[parameters1.Length + parameters2.Length];
                Array.Copy(parameters1, 0, parameters, 0, parameters1.Length);
                Array.Copy(parameters2, 0, parameters, parameters1.Length, parameters2.Length);

                return parameters;
            }
            if (null == parameters1 && null == parameters2)
                return new HttpParameter[0];
            if (parameters1 != null)
                return parameters1;
            return parameters2;
        }

        public static HttpParameter[] merge(HttpParameter[]parameters1,HttpParameter parameters2)
        {
            if((parameters1!=null) && parameters2 != null)
            {
                HttpParameter[] parameters = new HttpParameter[parameters1.Length + 1];
                Array.Copy(parameters1, 0, parameters, 0, parameters1.Length);
                parameters[(parameters1.Length - 1)] = parameters2;

                return parameters;
            }
            if (null == parameters1 && null == parameters2)
                return new HttpParameter[0];
            if (parameters1 != null)
                return parameters1;
            return new HttpParameter[] { parameters2 };
        }
    }
}
