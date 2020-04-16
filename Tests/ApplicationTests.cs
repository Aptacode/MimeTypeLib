using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Aptacode.MimeTypes.Tests
{
    public class BuiltInTypeTests
    {

        [Test]
        public void AllApplicationMimeTypes()
        {
            var mimeTypes = MimeTypes.Application.All();
            Assert.AreEqual(GetAllMimeTypes(typeof(MimeTypes.Application)),mimeTypes);
        }

        public IEnumerable<MimeType> GetAllMimeTypes(Type type)
        {
            return type.GetProperties().Select(p => p.GetValue(null, null) as MimeType).Where(p => p != null);
        }
    }
}