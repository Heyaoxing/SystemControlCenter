using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common.Tools
{
    /// <summary>
    /// 操作正则表达式的公共类
    /// </summary>    
    public static class RegexHelper
    {
        #region 字符处理
        /// <summary>
        /// 验证输入字符串是否与模式字符串匹配，匹配返回true
        /// </summary>
        /// <param name="input">输入字符串</param>
        /// <param name="pattern">模式字符串</param>        
        public static bool IsMatch(string input, string pattern)
        {
            return IsMatch(input, pattern, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// 验证输入字符串是否与模式字符串匹配，匹配返回true
        /// </summary>
        /// <param name="input">输入的字符串</param>
        /// <param name="pattern">模式字符串</param>
        /// <param name="options">筛选条件</param>
        public static bool IsMatch(string input, string pattern, RegexOptions options)
        {
            return Regex.IsMatch(input, pattern, options);
        }

        /// <summary>
        /// 验证输入字符串是否与模式字符串匹配，匹配返回匹配结果
        /// </summary>
        /// <param name="input">输入字符串</param>
        /// <param name="pattern">模式字符串</param>        
        public static string Match(string input, string pattern)
        {
            return Regex.Match(input, pattern, RegexOptions.IgnoreCase).Value;
        }

        /// <summary>
        /// 验证输入字符串是否与模式字符串匹配，匹配返回匹配结果统计数
        /// </summary>
        /// <param name="input">输入字符串</param>
        /// <param name="pattern">模式字符串</param>
        /// <returns></returns>
        public static int MatchCount(string input, string pattern)
        {
            return Regex.Matches(input, pattern, RegexOptions.IgnoreCase).Count;
        }

        /// <summary>
        /// 截取字符串中开始和结束字符串中间的字符串
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="startStr">开始字符串</param>
        /// <param name="endStr">结束字符串</param>
        /// <returns>中间字符串</returns>
        public static  string Substring(string source, string startStr, string endStr)
        {

            Regex rg = new Regex("(?<=(" + startStr + "))[.\\s\\S]*?(?=(" + endStr + "))", RegexOptions.Multiline | RegexOptions.Singleline);

            return rg.Match(source).Value;

        }

        /// <summary>
        /// 从字符串中获取电话号码
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <returns>源字符串中电话号码</returns>
        public static string GetTelephoneByString(string source)
        {
            return Regex.Match(source, @"(\(\d{3,4}-)|\d{3.4}-)?\d{7,8}").Groups[0].Value;
        }

        /// <summary>
        /// 从字符串中获取手机号码
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <returns>源字符串中手机号码</returns>
        public static string GetMobilephoneByString(string source)
        {
            return Regex.Match(source, @"[1]+[3,5,7,8]+\d{9}").Groups[0].Value;
        }

        /// <summary>
        /// 从字符串中获取身份证号码
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <returns>源字符串中身份证号码</returns>

        public static string GetIDCardByString(string source)
        {
            return Regex.Match(source, @"(^\d{15}$|^\d{18}$|^\d{17}(\d|X|x))").Groups[0].Value;
        }

        #endregion

        #region 数字处理
        #region 验证是否为浮点数
        /// <summary>
        /// 验证是否浮点数
        /// </summary>
        /// <param name="floatNum"></param>
        /// <returns></returns>
        public static bool IsFloat(this string floatNum)
        {
            //如果为空，认为验证不合格
            if (string.IsNullOrEmpty(floatNum))
            {
                return false;
            }
            //清除要验证字符串中的空格
            floatNum = floatNum.Trim();

            //模式字符串
            string pattern = @"^(-?\d+)(\.\d+)?$";

            //验证
            return RegexHelper.IsMatch(floatNum, pattern);
        }
        #endregion

        #region 验证是否为整数
        /// <summary>
        /// 验证是否为整数 如果为空，认为验证不合格 返回false
        /// </summary>
        /// <param name="number">要验证的整数</param>        
        public static bool IsInt(this string number)
        {
            //如果为空，认为验证不合格
            if (string.IsNullOrEmpty(number))
            {
                return false;
            }

            //清除要验证字符串中的空格
            number = number.Trim();

            //模式字符串
            string pattern = @"^[0-9]+[0-9]*$";

            //验证
            return RegexHelper.IsMatch(number, pattern);
        }
        #endregion

        #region 验证是否为数字
        /// <summary>
        /// 验证是否为数字
        /// </summary>
        /// <param name="number">要验证的数字</param>        
        public static bool IsNumber(this string number)
        {
            //如果为空，认为验证不合格
            if (string.IsNullOrEmpty(number))
            {
                return false;
            }

            //清除要验证字符串中的空格
            number = number.Trim();

            //模式字符串
            string pattern = @"^[0-9]+[0-9]*[.]?[0-9]*$";

            //验证
            return RegexHelper.IsMatch(number, pattern);
        }
        #endregion

        /// <summary>
        /// 从指定字符串中过滤出第一个数字
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <returns>源字符串的第一个数字</returns>
        public static string GetFirstNumberByString(string source)
        {

            return Regex.Match(source, @"\d+").Groups[0].Value;

        }



        /// <summary>
        /// 从指定字符串中过滤出最后一个数字
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <returns>源字符串的最后一个数字</returns>
        public static string GetLastNumberByString(string source)
        {

            var reg = Regex.Matches(source, @"\d+");

            return reg[reg.Count - 1].Value;

        }



        /// <summary>
        /// 从指定字符串中过滤出所有数字
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <returns>源字符串的所有数字</returns>
        public static List<string> GetAllNumberByString(string source)
        {

            var reg = Regex.Matches(source, @"\d+");

            List<string> list = new List<string>();

            foreach (Match item in reg)
            {

                list.Add(item.Value);

            }



            return list;

        }



        /// <summary>
        /// 检车源字符串中是否包含数字
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <returns>true:源字符串包含数字;false:源字符串不包含数字</returns>
        public static bool CheckNumberByString(string source)
        {

            return Regex.Match(source, @"\d").Success;

        }



        /// <summary>
        /// 判断字符串是否全部是数字且长度等于指定长度
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="length">指定长度</param>
        /// <returns>返回值</returns>
        public static bool CheckLengthByString(string source, int length)
        {

            Regex rg = new Regex(@"^\d{" + length + "}$");

            return rg.IsMatch(source);

        }
        #endregion

        #region 日期处理
        /// <summary>
        /// 是否是日期
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool IsDate(this object date)
        {

            //如果为空，认为验证合格
            if (date == null)
            {
                return false;
            }
            string strdate = date.ToString();
            try
            {
                //用转换测试是否为规则的日期字符
                date = Convert.ToDateTime(date).ToString("d");
                return true;
            }
            catch
            {
                //如果日期字符串中存在非数字，则返回false
                if (!IsInt(strdate))
                {
                    return false;
                }

                #region 对纯数字进行解析
                //对8位纯数字进行解析
                if (strdate.Length == 8)
                {
                    //获取年月日
                    string year = strdate.Substring(0, 4);
                    string month = strdate.Substring(4, 2);
                    string day = strdate.Substring(6, 2);

                    //验证合法性
                    if (Convert.ToInt32(year) < 1900 || Convert.ToInt32(year) > 2100)
                    {
                        return false;
                    }
                    if (Convert.ToInt32(month) > 12 || Convert.ToInt32(day) > 31)
                    {
                        return false;
                    }

                    //拼接日期
                    date = Convert.ToDateTime(year + "-" + month + "-" + day).ToString("d");
                    return true;
                }

                //对6位纯数字进行解析
                if (strdate.Length == 6)
                {
                    //获取年月
                    string year = strdate.Substring(0, 4);
                    string month = strdate.Substring(4, 2);

                    //验证合法性
                    if (Convert.ToInt32(year) < 1900 || Convert.ToInt32(year) > 2100)
                    {
                        return false;
                    }
                    if (Convert.ToInt32(month) > 12)
                    {
                        return false;
                    }

                    //拼接日期
                    date = Convert.ToDateTime(year + "-" + month).ToString("d");
                    return true;
                }

                //对5位纯数字进行解析
                if (strdate.Length == 5)
                {
                    //获取年月
                    string year = strdate.Substring(0, 4);
                    string month = strdate.Substring(4, 1);

                    //验证合法性
                    if (Convert.ToInt32(year) < 1900 || Convert.ToInt32(year) > 2100)
                    {
                        return false;
                    }

                    //拼接日期
                    date = year + "-" + month;
                    return true;
                }

                //对4位纯数字进行解析
                if (strdate.Length == 4)
                {
                    //获取年
                    string year = strdate.Substring(0, 4);

                    //验证合法性
                    if (Convert.ToInt32(year) < 1900 || Convert.ToInt32(year) > 2100)
                    {
                        return false;
                    }

                    //拼接日期
                    date = Convert.ToDateTime(year).ToString("d");
                    return true;
                }
                #endregion

                return false;
            }

        }
        /// <summary>
        /// 验证日期是否合法,对不规则的作了简单处理
        /// </summary>
        /// <param name="date">日期</param>
        public static bool IsDate(ref string date)
        {
            //如果为空，认为验证合格
            if (string.IsNullOrEmpty(date))
            {
                return true;
            }

            //清除要验证字符串中的空格
            date = date.Trim();

            //替换\
            date = date.Replace(@"\", "-");
            //替换/
            date = date.Replace(@"/", "-");

            //如果查找到汉字"今",则认为是当前日期
            if (date.IndexOf("今") != -1)
            {
                date = DateTime.Now.ToString();
            }

            try
            {
                //用转换测试是否为规则的日期字符
                date = Convert.ToDateTime(date).ToString("d");
                return true;
            }
            catch
            {
                //如果日期字符串中存在非数字，则返回false
                if (!IsInt(date))
                {
                    return false;
                }

                #region 对纯数字进行解析
                //对8位纯数字进行解析
                if (date.Length == 8)
                {
                    //获取年月日
                    string year = date.Substring(0, 4);
                    string month = date.Substring(4, 2);
                    string day = date.Substring(6, 2);

                    //验证合法性
                    if (Convert.ToInt32(year) < 1900 || Convert.ToInt32(year) > 2100)
                    {
                        return false;
                    }
                    if (Convert.ToInt32(month) > 12 || Convert.ToInt32(day) > 31)
                    {
                        return false;
                    }

                    //拼接日期
                    date = Convert.ToDateTime(year + "-" + month + "-" + day).ToString("d");
                    return true;
                }

                //对6位纯数字进行解析
                if (date.Length == 6)
                {
                    //获取年月
                    string year = date.Substring(0, 4);
                    string month = date.Substring(4, 2);

                    //验证合法性
                    if (Convert.ToInt32(year) < 1900 || Convert.ToInt32(year) > 2100)
                    {
                        return false;
                    }
                    if (Convert.ToInt32(month) > 12)
                    {
                        return false;
                    }

                    //拼接日期
                    date = Convert.ToDateTime(year + "-" + month).ToString("d");
                    return true;
                }

                //对5位纯数字进行解析
                if (date.Length == 5)
                {
                    //获取年月
                    string year = date.Substring(0, 4);
                    string month = date.Substring(4, 1);

                    //验证合法性
                    if (Convert.ToInt32(year) < 1900 || Convert.ToInt32(year) > 2100)
                    {
                        return false;
                    }

                    //拼接日期
                    date = year + "-" + month;
                    return true;
                }

                //对4位纯数字进行解析
                if (date.Length == 4)
                {
                    //获取年
                    string year = date.Substring(0, 4);

                    //验证合法性
                    if (Convert.ToInt32(year) < 1900 || Convert.ToInt32(year) > 2100)
                    {
                        return false;
                    }

                    //拼接日期
                    date = Convert.ToDateTime(year).ToString("d");
                    return true;
                }
                #endregion

                return false;
            }
        }

        /// <summary>
        /// 从字符串中获取第一个日期
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <returns>源字符串中的第一个日期</returns>
        public static string GetFirstDateByString(string source)
        {
            return Regex.Match(source, @"(\d{4}[\/\-](0?[1-9]|1[0-2])[\/\-]((0?[1-9])|((1|2)[0-9])|30|31))|((0?[1-9]|1[0-2])[\/\-]((0?[1-9])|((1|2)[0-9])|30|31)[\/\-]\d{4})").Groups[0].Value;
        }



        /// <summary>
        /// 从字符串中获取所有的日期
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <returns>源字符串中的所有日期</returns>
        public static List<string> GetAllDateByString(string source)
        {
            var all = Regex.Matches(source, @"(\d{4}[\/\-](0?[1-9]|1[0-2])[\/\-]((0?[1-9])|((1|2)[0-9])|30|31))|((0?[1-9]|1[0-2])[\/\-]((0?[1-9])|((1|2)[0-9])|30|31)[\/\-]\d{4})");
            List<string> list = new List<string>();
            foreach (Match item in all)
            {
                list.Add(item.Value);
            }
            return list;
        }

        /// <summary>
        /// 获取文本中的日期
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static DateTime GetPublishDate(string html)
        {
            // 过滤html标签，防止标签对日期提取产生影响
            string text = Regex.Replace(html, "(?is)<.*?>", "");
            Match match = Regex.Match(
                text,
                @"((\d{4}|\d{2})(\-|\/)\d{1,2}\3\d{1,2})(\s?\d{2}:\d{2})?|(\d{4}年\d{1,2}月\d{1,2}日)(\s?\d{2}:\d{2})?",
                RegexOptions.IgnoreCase);

            DateTime result = new DateTime(1900, 1, 1);
            if (match.Success)
            {
                try
                {
                    string dateStr = "";
                    for (int i = 0; i < match.Groups.Count; i++)
                    {
                        dateStr = match.Groups[i].Value;
                        if (!String.IsNullOrEmpty(dateStr))
                        {
                            break;
                        }
                    }
                    // 对中文日期的处理
                    if (dateStr.Contains("年"))
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (var ch in dateStr)
                        {
                            if (ch == '年' || ch == '月')
                            {
                                sb.Append("/");
                                continue;
                            }
                            if (ch == '日')
                            {
                                sb.Append(' ');
                                continue;
                            }
                            sb.Append(ch);
                        }
                        dateStr = sb.ToString();
                    }
                    result = Convert.ToDateTime(dateStr);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                if (result.Year < 1900)
                {
                    result = new DateTime(1900, 1, 1);
                }
            }
            return result;
        }
        #endregion

        #region 验证处理
        /// <summary>
        ///  //前台显示邮箱的掩码替换(由tzh@qq.com等替换成t*****@qq.com)
        /// </summary>
        /// <param name="Email">邮箱</param>
        /// <returns></returns>
        public static string GetEmail(string Email)
        {

            string strArg = "";
            string SendEmail = "";
            Match match = Regex.Match(Email, @"(\w)\w+@");

            if (match.Success)
            {
                strArg = match.Groups[1].Value + "*****@";
                SendEmail = Regex.Replace(Email, @"\w+@", strArg);
            }
            else
                SendEmail = Email;
            return SendEmail;
        }

        /// <summary>
        /// 匹配邮箱是否合法
        /// </summary>
        /// <param name="source">待匹配字符串</param>
        /// <returns>匹配结果true是邮箱反之不是邮箱</returns>
        public static bool CheckEmailByString(string source)
        {

            Regex rg = new Regex("^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\w+\\.)+\\w{2,5})\\s*$", RegexOptions.IgnoreCase);

            return rg.IsMatch(source);

        }


        /// <summary>
        /// 匹配URL是否合法
        /// </summary>
        /// <param name="source">待匹配字符串</param>
        /// <returns>匹配结果true是URL反之不是URL</returns>
        public static bool CheckURLByString(string source)
        {

            Regex rg = new Regex(@"^(https?|s?ftp):\/\/(((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:)*@)?(((\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5]))|((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?)(:\d*)?)(\/((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)+(\/(([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)*)*)?)?(\?((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)|[\uE000-\uF8FF]|\/|\?)*)?(#((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)|\/|\?)*)?$", RegexOptions.IgnoreCase);

            return rg.IsMatch(source);

        }

        /// <summary>
        /// 匹配日期是否合法
        /// </summary>
        /// <param name="source">待匹配字符串</param>
        /// <returns>匹配结果true是日期反之不是日期</returns>
        public static bool CheckDateByString(string source)
        {
            Regex rg = new Regex(@"^(\d{4}[\/\-](0?[1-9]|1[0-2])[\/\-]((0?[1-9])|((1|2)[0-9])|30|31))|((0?[1-9]|1[0-2])[\/\-]((0?[1-9])|((1|2)[0-9])|30|31)[\/\-]\d{4})$");
            return rg.IsMatch(source);
        }


        /// <summary>
        /// 检测密码复杂度是否达标：密码中必须包含字母、数字、特称字符，至少8个字符，最多16个字符。
        /// </summary>
        /// <param name="source">待匹配字符串</param>
        /// <returns>密码复杂度是否达标true是达标反之不达标</returns>
        public static bool CheckPasswordByString(string source)
        {
            Regex rg = new Regex(@"^(?=.*\d)(?=.*[a-zA-Z])(?=.*[^a-zA-Z0-9]).{8,16}$");
            return rg.IsMatch(source);
        }


        /// <summary>
        /// 匹配电话号码是否合法
        /// </summary>
        /// <param name="source">待匹配字符串</param>
        /// <returns>电话号码合法返回true,反之不合法</returns>
        public static bool CheckTelephoneByString(string source)
        {
            Regex rg = new Regex(@"^(\(\d{3,4}-)|\d{3.4}-)?\d{7,8}$");
            return rg.IsMatch(source);
        }

        /// <summary>
        /// 匹配手机号码是否合法
        /// </summary>
        /// <param name="source">待匹配字符串</param>
        /// <returns>手机号码合法返回true,反之不合法</returns>
        public static bool CheckMobilephoneByString(string source)
        {
            Regex rg = new Regex(@"^[1]+[3,5,7,8]+\d{9}$");
            return rg.IsMatch(source);
        }

        /// <summary>
        /// 匹配身份证号码是否合法
        /// </summary>
        /// <param name="source">待匹配字符串</param>
        /// <returns>身份证号码合法返回true,反之不合法</returns>
        public static bool CheckIDCardByString(string source)
        {
            Regex rg = new Regex(@"^(^\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$");
            return rg.IsMatch(source);
        }

        #endregion

        #region 网页解析

       

        /// <summary>
        /// 获取网页中的所有链接
        /// </summary>
        /// <param name="htmlContent"></param>
        /// <returns></returns>
        public static List<string> GetLinks(string htmlContent)
        {
            List<string> links = new List<string>();
            try
            {
                const string pattern = @"http://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
                MatchCollection matchCollection = regex.Matches(htmlContent);
                links.AddRange(from object link in matchCollection select link.ToString().TrimEnd('\\').Trim());
            }
            catch
            {
                // ignored
            }
            return links;
        }

        /// <summary>
        /// 获取排除掉资源文件后的有效链接
        /// </summary>
        /// <returns></returns>
        public static List<string> GetValidLinks(string htmlContent)
        {
            return GetLinks(htmlContent)
                       .Except(GetStyleCount(htmlContent))
                       .Except(GetImageLinks(htmlContent))
                       .Except(GetJsLinks(htmlContent)).Distinct().ToList();
        }

        /// <summary>
        /// 获取网站标题
        /// </summary>
        /// <param name="htmlContent">网页内容</param>
        /// <returns></returns>
        public static string GetTitle(string htmlContent)
        {
            var reg = new Regex(@"<title[^>]*?>(.*)<\/title>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            return reg.Match(htmlContent).Groups[1].Value;
        }



        /// <summary>
        /// 获取网站域名
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string GetDomainName(string url)
        {
            try
            {
                const string pattern = @"https?://(.*?)($|/)";
                string host = Match(url, pattern);
                if (!string.IsNullOrWhiteSpace(host))
                    host = host.TrimEnd('/');
                return host;
            }
            catch
            {
                // ignored
            }
            return string.Empty;
        }


        /// <summary>
        /// 读取网页编码
        /// </summary>
        /// <param name="htmlContent">网页内容</param>
        /// <returns></returns>
        public static string GetEncoding(string htmlContent)
        {
            try
            {
                var reg = new Regex(@"<meta.+?charset=[^\w]?([-\w]+)", RegexOptions.IgnoreCase);
                string encodingStirng = reg.Match(htmlContent).Groups[1].Value;
                if (string.IsNullOrWhiteSpace(encodingStirng) || encodingStirng == "“”")
                    encodingStirng = "utf-8";
                return encodingStirng;
            }
            catch (Exception ex)
            {
                // ignored
            }
            return "gb18030";
        }

        /// <summary>
        /// 获取网页关键字
        /// </summary>
        /// <param name="htmlContent"></param>
        /// <returns></returns>
        public static string GetKeyWords(string htmlContent)
        {
            try
            {
                const string pattern = "(?<=meta[^>]*?name=\"keywords\"[^>]*?content=\").*?(?=\")";
                return Match(htmlContent, pattern);
            }
            catch (Exception)
            {
                // ignored
            }
            return string.Empty;
        }

        /// <summary>
        /// 获取网页描述
        /// </summary>
        /// <param name="htmlContent"></param>
        /// <returns></returns>
        public static string GetDescription(string htmlContent)
        {
            try
            {
                const string pattern = "(?<=meta[^>]*?name=\"description\"[^>]*?content=\").*?(?=\")";
                return Match(htmlContent, pattern);
            }
            catch (Exception)
            {
                // ignored
            }
            return string.Empty;
        }

        /// <summary>
        /// 获取所有资源链接集合
        /// </summary>
        /// <param name="htmlContent"></param>
        /// <returns></returns>
        public static List<string> GetResources(string htmlContent)
        {
            List<string> links = new List<string>();
            try
            {
                const string jsPattern = "(?<=script[^>]*?src=\").*?(?=\")";
                const string cssPattern = "(?<=link[^>]*?href=\").*?(?=\")";
                const string imgPattern = "(?<=a[^>]*?href=\").*?(?=\")";
                const string aPattern = "(?<=img[^>]*?src=\").*?(?=\")";
                MatchCollection jsMatch = Regex.Matches(htmlContent, jsPattern, RegexOptions.IgnoreCase);
                MatchCollection cssMatch = Regex.Matches(htmlContent, cssPattern, RegexOptions.IgnoreCase);
                MatchCollection imgMatch = Regex.Matches(htmlContent, imgPattern, RegexOptions.IgnoreCase);
                MatchCollection aMatch = Regex.Matches(htmlContent, aPattern, RegexOptions.IgnoreCase);
                links.AddRange(from object link in jsMatch select link.ToString().Trim());
                links.AddRange(from object link in cssMatch select link.ToString().Trim());
                links.AddRange(from object link in imgMatch select link.ToString().Trim());
                links.AddRange(from object link in aMatch select link.ToString().Trim());
            }
            catch
            {
                // ignored
            }
            return links;
        }

        /// <summary>
        /// 获取所有样式文件链接
        /// </summary>
        /// <param name="htmlContent"></param>
        /// <returns></returns>
        public static List<string> GetStyleCount(string htmlContent)
        {
            List<string> links = new List<string>();
            try
            {
                const string cssPattern = "(?<=link[^>]*?href=\").*?(?=\")";
                MatchCollection cssMatch = Regex.Matches(htmlContent, cssPattern, RegexOptions.IgnoreCase);
                links.AddRange(from object link in cssMatch select link.ToString().Trim());
            }
            catch
            {
                // ignored
            }
            return links;
        }

        /// <summary>
        /// 获取所有脚本文件链接
        /// </summary>
        /// <param name="htmlContent"></param>
        /// <returns></returns>
        public static List<string> GetJsLinks(string htmlContent)
        {
            List<string> links = new List<string>();
            try
            {
                const string aPattern = "(?<=img[^>]*?src=\").*?(?=\")";
                MatchCollection cssMatch = Regex.Matches(htmlContent, aPattern, RegexOptions.IgnoreCase);
                links.AddRange(from object link in cssMatch select link.ToString().Trim());
            }
            catch
            {
                // ignored
            }
            return links;
        }

        /// <summary>
        /// 获取所有图片文件链接
        /// </summary>
        /// <param name="htmlContent"></param>
        /// <returns></returns>
        public static List<string> GetImageLinks(string htmlContent)
        {
            List<string> links = new List<string>();
            try
            {
                const string jsPattern = "(?<=script[^>]*?src=\").*?(?=\")";
                MatchCollection cssMatch = Regex.Matches(htmlContent, jsPattern, RegexOptions.IgnoreCase);
                links.AddRange(from object link in cssMatch select link.ToString().Trim());
            }
            catch
            {
                // ignored
            }
            return links;
        }

        /// <summary>
        /// 获取所有img标签
        /// </summary>
        /// <param name="htmlContent"></param>
        /// <returns></returns>
        public static List<string> GetImgs(string htmlContent)
        {
            List<string> imgs = new List<string>();
            try
            {
                const string pattern = "<img[^>]*?>";
                MatchCollection match = Regex.Matches(htmlContent, pattern, RegexOptions.IgnoreCase);
                imgs.AddRange(from object link in match select link.ToString().Trim());
            }
            catch
            {
                // ignored
            }
            return imgs;
        }

        /// <summary>
        /// 通过dom元素和元素值获得标签内文本
        /// 默认匹配第一个
        /// </summary>
        /// <param name="htmlContent">html内容</param>
        /// <param name="dom">标签</param>
        /// <param name="attribute">属性</param>
        /// <param name="attrValue">属性值</param>
        /// <param name="index">取第几个符合条件的匹配值</param>
        /// <returns></returns>
        public static string GetContentByDomAttr(string htmlContent, string dom, string attribute, string attrValue, int index = 0)
        {
            try
            {
                string pattern = string.Format("<{0}.*?{1}=\"{2}.*?\">(.*?)<\\/{0}>", dom, attribute, attrValue);
                return new Regex(pattern).Matches(htmlContent)[index].Groups[1].Value;
            }
            catch
            {
                // ignored
            }
            return string.Empty;
        }

        /// <summary>
        /// 获取指定标签的属性值
        /// </summary>
        /// <param name="htmlContent"></param>
        /// <returns></returns>
        public static string GetTagAttrValue(string htmlContent, string dom, string attribute, int index = 0)
        {
            try
            {
                string pattern = string.Format("(?<={0}[^>]*?{1}=\").*?(?=\")", dom, attribute);
                return new Regex(pattern).Matches(htmlContent)[index].Groups[1].Value;
            }
            catch
            {
                // ignored
            }
            return string.Empty;
        }

        /// <summary>
        /// 通过标签获得标签内文本
        /// 默认匹配第一个
        /// </summary>
        /// <param name="htmlContent"></param>
        /// <param name="dom">标签</param>
        /// <param name="index">取第几个符合条件的匹配值</param>
        /// <returns></returns>
        public static string GetContentByDom(string htmlContent, string dom, int index = 0)
        {
            try
            {
                string pattern = string.Format("<{0}.*?>(.*?)<\\/{0}>", dom);
                return new Regex(pattern).Matches(htmlContent)[index].Groups[1].Value;
            }
            catch
            {
                // ignored
            }
            return string.Empty;
        }

        /// <summary>
        /// 去除html标签
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string ReplaceHtmlTag(string html)
        {
            string strText = Regex.Replace(html, "<[^>]+>", "");
            strText = Regex.Replace(strText, "&[^;]+;", "");
            return strText;
        }

        /// <summary>
        ///获取指定的所有标签
        /// </summary>
        /// <param name="htmlContent"></param>
        /// <param name="dom"></param>
        /// <returns></returns>
        public static List<string> GetDoms(string htmlContent, string dom)
        {
            List<string> tags = new List<string>();
            try
            {
                string pattern = string.Format("<{0}[^>].*?>.*?</{0}>", dom);
                MatchCollection match = Regex.Matches(htmlContent, pattern, RegexOptions.IgnoreCase);
                tags.AddRange(from object link in match select link.ToString().Trim());
            }
            catch
            {
                // ignored
            }
            return tags;
        }
        #endregion
    }
}
