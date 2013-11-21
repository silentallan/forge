﻿using System;

namespace Neon.Serialization {
    /// <summary>
    /// Extensions to the Type API.
    /// </summary>
    public static class TypeExtensions {
        /// <summary>
        /// Searches for a particular implementation of the given interface type inside of the type.
        /// This is particularly useful if the interface type is an open type, ie, typeof(IFace[]),
        /// because this method will then return IFace[] but with appropriate type parameters
        /// inserted.
        /// </summary>
        /// <param name="type">The base type to search for interface</param>
        /// <param name="interfaceType">The interface type to search for. Can be an open generic
        /// type.</param>
        /// <returns>The actual interface type that the type contains, or null if there is no
        /// implementation of the given interfaceType on type.</returns>
        public static Type GetInterface(this Type type, Type interfaceType) {
            while (type != null) {
                foreach (var iface in type.GetInterfaces()) {
                    if (interfaceType.IsGenericTypeDefinition) {
                        if (iface.GetGenericTypeDefinition() == interfaceType) {
                            return iface;
                        }
                    }

                    else if (iface == interfaceType) {
                        return iface;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Returns true if the baseType is an implementation of the given interface type. The
        /// interface type can be generic.
        /// </summary>
        /// <param name="type">The type to search for an implementation of the given
        /// interface</param>
        /// <param name="interfaceType">The interface type to search for</param>
        /// <returns></returns>
        public static bool IsImplementationOf(this Type type, Type interfaceType) {
            if (interfaceType.IsGenericType) {
                interfaceType = interfaceType.GetGenericTypeDefinition();
            }
            if (type.IsGenericType) {
                type = type.GetGenericTypeDefinition();
            }

            while (type != null) {
                foreach (var iface in type.GetInterfaces()) {
                    if (iface.IsGenericType) {
                        if (interfaceType == iface.GetGenericTypeDefinition()) {
                            return true;
                        }
                    }

                    else if (interfaceType == iface) {
                        return true;
                    }
                }

                type = type.BaseType;
            }

            return false;
        }
    }
}