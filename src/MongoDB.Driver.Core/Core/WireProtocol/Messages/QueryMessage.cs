﻿/* Copyright 2013-2014 MongoDB Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/


using System;
using MongoDB.Bson;
using MongoDB.Driver.Core.Misc;
using MongoDB.Driver.Core.WireProtocol.Messages.Encoders;

namespace MongoDB.Driver.Core.WireProtocol.Messages
{
    public class QueryMessage : RequestMessage
    {
        // fields
        private readonly bool _awaitData;
        private readonly int _batchSize;
        private readonly string _collectionName;
        private readonly string _databaseName;
        private readonly BsonDocument _fields;
        private readonly bool _noCursorTimeout;
        private readonly bool _partialOk;
        private readonly BsonDocument _query;
        private readonly int _skip;
        private readonly bool _slaveOk;
        private readonly bool _tailableCursor;

        // constructors
        public QueryMessage(
            int requestId,
            string databaseName,
            string collectionName,
            BsonDocument query,
            BsonDocument fields,
            int skip,
            int batchSize,
            bool slaveOk,
            bool partialOk,
            bool noCursorTimeout,
            bool tailableCursor,
            bool awaitData,
            Func<bool> shouldBeSent = null)
            : base(requestId, shouldBeSent)
        {
            _databaseName = Ensure.IsNotNullOrEmpty(databaseName, "databaseName");
            _collectionName = Ensure.IsNotNullOrEmpty(collectionName, "collectionName");
            _query = Ensure.IsNotNull(query, "query");
            _fields = fields; // can be null
            _skip = Ensure.IsGreaterThanOrEqualToZero(skip, "skip");
            _batchSize = batchSize; // can be negative
            _slaveOk = slaveOk;
            _partialOk = partialOk;
            _noCursorTimeout = noCursorTimeout;
            _tailableCursor = tailableCursor;
            _awaitData = awaitData;
        }

        // properties
        public bool AwaitData
        {
            get { return _awaitData; }
        }

        public int BatchSize
        {
            get { return _batchSize; }
        }

        public string CollectionName
        {
            get { return _collectionName; }
        }

        public string DatabaseName
        {
            get { return _databaseName; }
        }

        public BsonDocument Fields
        {
            get { return _fields; }
        }

        public bool NoCursorTimeout
        {
            get { return _noCursorTimeout; }
        }

        public bool PartialOk
        {
            get { return _partialOk; }
        }

        public BsonDocument Query
        {
            get { return _query; }
        }

        public int Skip
        {
            get { return _skip; }
        }

        public bool SlaveOk
        {
            get { return _slaveOk; }
        }

        public bool TailableCursor
        {
            get { return _tailableCursor; }
        }

        // methods
        public new IMessageEncoder<QueryMessage> GetEncoder(IMessageEncoderFactory encoderFactory)
        {
            return encoderFactory.GetQueryMessageEncoder();
        }

        protected override IMessageEncoder GetNonGenericEncoder(IMessageEncoderFactory encoderFactory)
        {
            return GetEncoder(encoderFactory);
        }
    }
}
