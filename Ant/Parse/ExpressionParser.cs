using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ant.Parse
{
    public class ExpressionParser
    {
        public T GetResult<T>(string expression) 
        {
            var result = ExeExpression(expression);
            return (T)result;
        }


        /// <summary>
        /// 执行表达式，获取结果
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        private object ExeExpression(string expression)
        {
            return true;
        }

    }
}
