﻿using Models.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMIS_API.Models.Common
{

    public class CommonUtility
    {
        public static Response<T> GetResponse<T>(T data, string messages = null) where T : class
        {
            return new Response<T>() { IsException = false, Messages = messages ?? string.Empty, Data = data };
        }
        public static Response<T> GetExResponse<T>(Exception ex) where T : class
        {
            return new Response<T>() { IsException = true, Messages = GetExMessage(ex), Data = null };
        }
        public static Response<T> GetExResponse<T>(string message) where T : class
        {
            return new Response<T>() { IsException = true, Messages = message, Data = null };
        }
        public static DateTime GetPkCurrentDateTime()
        {
            return DateTime.UtcNow.AddHours(5);
        }
        public static int ToInt32(string value)
        {
            if (value == null)
                return 0;
            return int.Parse(value, CultureInfo.CurrentCulture);
        }
        public static Guid GenereateGuid()
        {
            try
            {
                Guid guid = System.Guid.NewGuid();
                return guid;
            }
            catch
            {
                throw;
            }
        }
        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        public static string GetExMessage(Exception message)
        {
            var msg = string.Empty;
            if (message == null) return msg;
            msg += message.Message;
            if (message.InnerException != null)
            {
                msg += "\r\nInnerException: " + GetExMessage(message.InnerException);
            }
            return msg;
        }
    }
}
