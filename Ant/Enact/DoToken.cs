using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ant.Entity.Esse;
using Model;

namespace Ant.Enact
{
    public class DoToken
    {
        public Token Token { get; set; }

        /// <summary>
        /// 新建一个Token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public Token CreateToken(Token token)
        {
            return token;
        }

        /// <summary>
        /// 分裂/合并 原来的Token为num个Token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public List<Token> ConvertToken(List<Token> tokens, int num)
        {
            DestroyTokens(tokens);
            
            return new List<Token>();
        }

        public void DestroyToken(Token tokens)
        {
            //删除数据库代码

        }

        public void DestroyTokens(List<Token> tokens) 
        {
            //删除数据库代码

        }
    }
}
