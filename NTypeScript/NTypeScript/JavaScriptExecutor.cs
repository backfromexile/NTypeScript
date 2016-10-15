﻿using Jurassic;

namespace IridiumIon.NTypeScript
{
    /// <summary>
    /// A super-light wrapper around the JurassicJS engine for quick scripting without
    /// referencing Jurassic.
    /// </summary>
    public class JavaScriptExecutor
    {
        public ScriptEngine JSEngine { get; set; }

        public JavaScriptExecutor()
        {
            JSEngine = new ScriptEngine();
        }

        /// <summary>
        /// Injects a Console implementation into the script engine. This allows the use of console.log() and more...
        /// </summary>
        public void EnableConsoleApi()
        {
            JSEngine.SetGlobalValue("console", new Jurassic.Library.FirebugConsole(JSEngine));
        }

        public T Evaluate<T>(string expression)
        {
            return JSEngine.Evaluate<T>(expression);
        }

        public void Execute(string code)
        {
            JSEngine.Execute(code);
        }
    }
}