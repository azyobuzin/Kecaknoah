﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Kecaknoah
{
    /// <summary>
    /// Kecaknoahで定義されるクラスを定義します。
    /// </summary>
    public sealed class KecaknoahScriptClassInfo : KecaknoahClassInfo
    {
        internal List<KecaknoahScriptClassInfo> inners = new List<KecaknoahScriptClassInfo>();
        internal List<KecaknoahScriptMethodInfo> methods = new List<KecaknoahScriptMethodInfo>();
        internal List<KecaknoahScriptMethodInfo> classMethods = new List<KecaknoahScriptMethodInfo>();
        private List<string> locals = new List<string>();

        /// <summary>
        /// 新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="name">クラス名</param>
        public KecaknoahScriptClassInfo(string name)
        {
            Name = name;
            Locals = locals;
            InnerClasses = inners;
            InstanceMethods = methods;
            ClassMethods = classMethods;
        }

        /// <summary>
        /// インナークラスを追加します。
        /// </summary>
        /// <param name="klass">追加するクラス</param>
        internal void AddInnerClass(KecaknoahScriptClassInfo klass)
        {
            if (inners.Any(p => p.Name == klass.Name)) throw new ArgumentException("同じ名前のインナークラスがすでに存在します。");
            inners.Add(klass);
        }

        /// <summary>
        /// メソッドを追加します。
        /// </summary>
        /// <param name="method">追加するメソッド</param>
        internal void AddInstanceMethod(KecaknoahScriptMethodInfo method)
        {
            methods.Add(method);
        }

        /// <summary>
        /// メソッドを追加します。
        /// </summary>
        /// <param name="method">追加するメソッド</param>
        internal void AddClassMethod(KecaknoahScriptMethodInfo method)
        {
            classMethods.Add(method);
        }

        /// <summary>
        /// フィールドを追加します。
        /// </summary>
        /// <param name="local">追加するメソッド</param>
        internal void AddLocal(string local)
        {
            locals.Add(local);
        }
    }
}
