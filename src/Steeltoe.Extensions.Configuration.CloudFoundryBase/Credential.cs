﻿// Copyright 2017 the original author or authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;
using System.ComponentModel;

namespace Steeltoe.Extensions.Configuration.CloudFoundry
{
    [TypeConverter(typeof(CredentialConverter))]
    public class Credential : Dictionary<string, Credential>
    {
        private string _value;

        public Credential()
        {
        }

        public Credential(string value)
        {
            _value = value;
        }

        public string Value
        {
            get
            {
                return _value;
            }
        }
    }
}
