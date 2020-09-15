using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Text.RegularExpressions;

namespace Unit
{
    /// <summary>
    /// 慢查询拦截器
    /// </summary>
    public class HintCommandInterceptor : DbCommandInterceptor
    {
        public static readonly Regex Sql_Like = new Regex(@"LOCATE\(CONVERT\('(?<v>.+?)' USING utf8mb4\) COLLATE utf8mb4_bin, (?<k>`.+`?)\) > 0",RegexOptions.Compiled | RegexOptions.IgnoreCase);
        /// <summary>
        /// 拦截模糊查询
        /// </summary>
        /// <param name="command"></param>
        /// <param name="eventData"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public override InterceptionResult<DbDataReader> ReaderExecuting(DbCommand command, CommandEventData eventData, InterceptionResult<DbDataReader> result)
        {
          
            return result;
        }
    }
}
