using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Ant.Entity.Esse;
using Ant.Data;

namespace Ant.Enact.Pattern
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

        public void DestroyToken(Token tokens)
        {
            //删除数据库代码

        }

        /// <summary>
        /// 挂起Token，转变成等待状态
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public void SuspendToken(Token token)
        {            
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

        public void DestroyTokens(List<Token> tokens) 
        {
            //删除数据库代码

        }
    }
}
