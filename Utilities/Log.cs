﻿using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Neon.Utilities {
    /// <summary>
    /// Log messages.
    /// </summary>
    /// <typeparam name="T">The type that is sending the log message</typeparam>
    public static class Log<T> {
        /// <summary>
        /// The log4net logger used to log messages.
        /// </summary>
        private static ILog _log;

        static Log() {
            _log = LogManager.GetLogger(typeof(T));
        }


        #region Debug
        public static void Debug(object message) {
            _log.Debug(message);
        }
        public static void Debug<T0>(string format, T0 arg0) {
            if (_log.IsDebugEnabled) {
                _log.Debug(FastStringFormat.Format(format, arg0));
            }
        }
        public static void Debug<T0, T1>(string format, T0 arg0, T1 arg1) {
            if (_log.IsDebugEnabled) {
                _log.Debug(FastStringFormat.Format(format, arg0, arg1));
            }
        }
        public static void Debug<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2) {
            if (_log.IsDebugEnabled) {
                _log.Debug(FastStringFormat.Format(format, arg0, arg1, arg2));
            }
        }
        public static void Debug<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) {
            if (_log.IsDebugEnabled) {
                _log.Debug(FastStringFormat.Format(format, arg0, arg1, arg2, arg3));
            }
        }
        public static void Debug<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
            if (_log.IsDebugEnabled) {
                _log.Debug(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4));
            }
        }
        public static void Debug<T0, T1, T2, T3, T4, T5>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
            if (_log.IsDebugEnabled) {
                _log.Debug(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5));
            }
        }
        public static void Debug<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
            if (_log.IsDebugEnabled) {
                _log.Debug(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6));
            }
        }
        public static void Debug<T0, T1, T2, T3, T4, T5, T6, T7>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
            if (_log.IsDebugEnabled) {
                _log.Debug(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
            }
        }
        public static void Debug<T0, T1, T2, T3, T4, T5, T6, T7, T8>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
            if (_log.IsDebugEnabled) {
                _log.Debug(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
            }
        }
        public static void Debug<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
            if (_log.IsDebugEnabled) {
                _log.Debug(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
            }
        }
        #endregion

        #region Info
        public static void Info(object message) {
            return;
            _log.Info(message);
        }
        public static void Info<T0>(string format, T0 arg0) {
            return;
            if (_log.IsInfoEnabled) {
                _log.Info(FastStringFormat.Format(format, arg0));
            }
        }
        public static void Info<T0, T1>(string format, T0 arg0, T1 arg1) {
            return;
            if (_log.IsInfoEnabled) {
                _log.Info(FastStringFormat.Format(format, arg0, arg1));
            }
        }
        public static void Info<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2) {
            return;
            if (_log.IsInfoEnabled) {
                _log.Info(FastStringFormat.Format(format, arg0, arg1, arg2));
            }
        }
        public static void Info<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) {
            return;
            if (_log.IsInfoEnabled) {
                _log.Info(FastStringFormat.Format(format, arg0, arg1, arg2, arg3));
            }
        }
        public static void Info<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
            return;
            if (_log.IsInfoEnabled) {
                _log.Info(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4));
            }
        }
        public static void Info<T0, T1, T2, T3, T4, T5>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
            return;
            if (_log.IsInfoEnabled) {
                _log.Info(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5));
            }
        }
        public static void Info<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
            if (_log.IsInfoEnabled) {
                _log.Info(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6));
            }
        }
        public static void Info<T0, T1, T2, T3, T4, T5, T6, T7>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
            if (_log.IsInfoEnabled) {
                _log.Info(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
            }
        }
        public static void Info<T0, T1, T2, T3, T4, T5, T6, T7, T8>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
            if (_log.IsInfoEnabled) {
                _log.Info(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
            }
        }
        public static void Info<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
            if (_log.IsInfoEnabled) {
                _log.Info(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
            }
        }
        #endregion

        #region Warn
        public static void Warn(object message) {
            _log.Warn(message);
        }
        public static void Warn<T0>(string format, T0 arg0) {
            if (_log.IsWarnEnabled) {
                _log.Warn(FastStringFormat.Format(format, arg0));
            }
        }
        public static void Warn<T0, T1>(string format, T0 arg0, T1 arg1) {
            if (_log.IsWarnEnabled) {
                _log.Warn(FastStringFormat.Format(format, arg0, arg1));
            }
        }
        public static void Warn<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2) {
            if (_log.IsWarnEnabled) {
                _log.Warn(FastStringFormat.Format(format, arg0, arg1, arg2));
            }
        }
        public static void Warn<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) {
            if (_log.IsWarnEnabled) {
                _log.Warn(FastStringFormat.Format(format, arg0, arg1, arg2, arg3));
            }
        }
        public static void Warn<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
            if (_log.IsWarnEnabled) {
                _log.Warn(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4));
            }
        }
        public static void Warn<T0, T1, T2, T3, T4, T5>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
            if (_log.IsWarnEnabled) {
                _log.Warn(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5));
            }
        }
        public static void Warn<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
            if (_log.IsWarnEnabled) {
                _log.Warn(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6));
            }
        }
        public static void Warn<T0, T1, T2, T3, T4, T5, T6, T7>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
            if (_log.IsWarnEnabled) {
                _log.Warn(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
            }
        }
        public static void Warn<T0, T1, T2, T3, T4, T5, T6, T7, T8>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
            if (_log.IsWarnEnabled) {
                _log.Warn(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
            }
        }
        public static void Warn<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
            if (_log.IsWarnEnabled) {
                _log.Warn(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
            }
        }
        #endregion

        #region Error
        public static void Error(object message) {
            _log.Error(message);
        }
        public static void Error<T0>(string format, T0 arg0) {
            if (_log.IsErrorEnabled) {
                _log.Error(FastStringFormat.Format(format, arg0));
            }
        }
        public static void Error<T0, T1>(string format, T0 arg0, T1 arg1) {
            if (_log.IsErrorEnabled) {
                _log.Error(FastStringFormat.Format(format, arg0, arg1));
            }
        }
        public static void Error<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2) {
            if (_log.IsErrorEnabled) {
                _log.Error(FastStringFormat.Format(format, arg0, arg1, arg2));
            }
        }
        public static void Error<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) {
            if (_log.IsErrorEnabled) {
                _log.Error(FastStringFormat.Format(format, arg0, arg1, arg2, arg3));
            }
        }
        public static void Error<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
            if (_log.IsErrorEnabled) {
                _log.Error(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4));
            }
        }
        public static void Error<T0, T1, T2, T3, T4, T5>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
            if (_log.IsErrorEnabled) {
                _log.Error(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5));
            }
        }
        public static void Error<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
            if (_log.IsErrorEnabled) {
                _log.Error(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6));
            }
        }
        public static void Error<T0, T1, T2, T3, T4, T5, T6, T7>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
            if (_log.IsErrorEnabled) {
                _log.Error(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
            }
        }
        public static void Error<T0, T1, T2, T3, T4, T5, T6, T7, T8>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
            if (_log.IsErrorEnabled) {
                _log.Error(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
            }
        }
        public static void Error<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
            if (_log.IsErrorEnabled) {
                _log.Error(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
            }
        }
        #endregion

        #region Fatal
        public static void Fatal(object message) {
            _log.Fatal(message);
        }
        public static void Fatal<T0>(string format, T0 arg0) {
            if (_log.IsFatalEnabled) {
                _log.Fatal(FastStringFormat.Format(format, arg0));
            }
        }
        public static void Fatal<T0, T1>(string format, T0 arg0, T1 arg1) {
            if (_log.IsFatalEnabled) {
                _log.Fatal(FastStringFormat.Format(format, arg0, arg1));
            }
        }
        public static void Fatal<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2) {
            if (_log.IsFatalEnabled) {
                _log.Fatal(FastStringFormat.Format(format, arg0, arg1, arg2));
            }
        }
        public static void Fatal<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) {
            if (_log.IsFatalEnabled) {
                _log.Fatal(FastStringFormat.Format(format, arg0, arg1, arg2, arg3));
            }
        }
        public static void Fatal<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
            if (_log.IsFatalEnabled) {
                _log.Fatal(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4));
            }
        }
        public static void Fatal<T0, T1, T2, T3, T4, T5>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
            if (_log.IsFatalEnabled) {
                _log.Fatal(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5));
            }
        }
        public static void Fatal<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
            if (_log.IsFatalEnabled) {
                _log.Fatal(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6));
            }
        }
        public static void Fatal<T0, T1, T2, T3, T4, T5, T6, T7>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
            if (_log.IsFatalEnabled) {
                _log.Fatal(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
            }
        }
        public static void Fatal<T0, T1, T2, T3, T4, T5, T6, T7, T8>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
            if (_log.IsFatalEnabled) {
                _log.Fatal(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
            }
        }
        public static void Fatal<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
            if (_log.IsFatalEnabled) {
                _log.Fatal(FastStringFormat.Format(format, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
            }
        }
        #endregion
    }
}
