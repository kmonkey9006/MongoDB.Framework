﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MongoDB.Framework
{
    public interface IRegistrationContext
    {
        /// <summary>
        /// register IMongoDBContext
        /// </summary>
        /// <param name="context">IMongoDBContext</param>
        void RegisterDBContext(IMongoDBContext context);

        /// <summary>
        /// unique code for IMongoDBContext(default: connectionstring name in config file)
        /// </summary>
        string Code { get; }
        /// <summary>
        /// database name(default: get from config file)
        /// </summary>
        string DBName { get; }

        /// <summary>
        /// is type registered
        /// </summary>
        /// <typeparam name="T">collection type</typeparam>
        /// <returns></returns>
        bool IsRegisterType<T>();
        /// <summary>
        /// is type registered
        /// </summary>
        /// <param name="type">collection type</param>
        /// <returns></returns>
        bool IsRegisterType(Type type);

        /// <summary>
        /// unregister type
        /// </summary>
        /// <param name="type">collection type</param>
        void UnregisterType(Type type);
        /// <summary>
        /// register type
        /// </summary>
        /// <param name="type">collection type</param>
        void RegisterType(Type type);

        /// <summary>
        /// get all registered types
        /// </summary>
        /// <returns></returns>
        List<Type> GetAllTypes();

        /// <summary>
        /// return MongoUrl
        /// </summary>
        /// <returns></returns>
        MongoUrl GetMongoUrl();

        /// <summary>
        /// ensure index to mongodb
        /// </summary>
        void EnsureDBIndex();

        /// <summary>
        /// ensure index of type to mongodb
        /// </summary>
        /// <param name="type"></param>
        void EnsureDBIndex(Type type);
    }
}
