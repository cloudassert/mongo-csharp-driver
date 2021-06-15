/* Copyright 2010-present MongoDB Inc.
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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MongoDB.Bson;

[assembly: CLSCompliant(true)]
[assembly: ComVisible(false)]

// Prevents the Xamarin static linker from stripping anything from this assembly.
// Required for most of the reflection usage in Xamarin.iOS/Xamarin.Mac.
[assembly: Preserve(AllMembers = true)]

[assembly: InternalsVisibleTo("MongoDB.Driver.Legacy.TestHelpers, PublicKey=0024000004800000940000000602000000240000525341310004000001000100557f78f72aa26a8ac4b5ae55ba25b2e82fe12c3288c5874fce94983fa87754e788d49a23a711c2f1b4c55b4d45e3f465901d25718f12fe861985d3a44a1b0e9cf385f588fd062f21cdd89fec75d84a0c7e7bdd4b2e1555435f6f039ce917c7a136482e30f5571e2137042217a9c0a3e0e24bc15c9f7201ff224329cc7ace29b0")]
[assembly: InternalsVisibleTo("MongoDB.Driver.Legacy.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100557f78f72aa26a8ac4b5ae55ba25b2e82fe12c3288c5874fce94983fa87754e788d49a23a711c2f1b4c55b4d45e3f465901d25718f12fe861985d3a44a1b0e9cf385f588fd062f21cdd89fec75d84a0c7e7bdd4b2e1555435f6f039ce917c7a136482e30f5571e2137042217a9c0a3e0e24bc15c9f7201ff224329cc7ace29b0")]
