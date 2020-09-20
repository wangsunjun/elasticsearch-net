#region Utf8Json License https://github.com/neuecc/Utf8Json/blob/master/LICENSE
// MIT License
//
// Copyright (c) 2017 Yoshifumi Kawai
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion


namespace Elastic.Transport.Utf8Json
{
	public delegate void JsonSerializeAction<in T>(ref JsonWriter writer, T value, IJsonFormatterResolver resolver);
	public delegate T JsonDeserializeFunc<out T>(ref JsonReader reader, IJsonFormatterResolver resolver);

	public interface IJsonFormatter
    {
    }

	public interface IJsonFormatter<T> : IJsonFormatter
    {
        void Serialize(ref JsonWriter writer, T value, IJsonFormatterResolver formatterResolver);
        T Deserialize(ref JsonReader reader, IJsonFormatterResolver formatterResolver);
    }

	public interface IObjectPropertyNameFormatter<T>
    {
        void SerializeToPropertyName(ref JsonWriter writer, T value, IJsonFormatterResolver formatterResolver);
        T DeserializeFromPropertyName(ref JsonReader reader, IJsonFormatterResolver formatterResolver);
    }
}