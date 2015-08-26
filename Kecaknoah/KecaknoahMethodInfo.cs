﻿using Kecaknoah.Type;

namespace Kecaknoah
{
    /// <summary>
    /// Kecaknoahで利用されるメソッドの規定を定義します。
    /// </summary>
    public abstract class KecaknoahMethodInfo
    {
        /// <summary>
        /// このメソッドの名前を取得します。
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// 引数の数を取得します。
        /// </summary>
        public abstract int ArgumentLength { get; }

        /// <summary>
        /// 可変長引数メソッドかどうかを取得します。
        /// </summary>
        public abstract bool VariableArgument { get; }

        /// <summary>
        /// 実際に呼び出し可能な<see cref="KecaknoahObject"/>を生成します。
        /// </summary>
        /// <returns>Callできる<see cref="KecaknoahObject"/></returns>
        public abstract KecaknoahObject CreateFunctionObject();
    }
}