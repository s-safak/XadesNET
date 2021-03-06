﻿using NUnit.Framework;
using XadesNetLib.Utils.Certificates;
using XadesNetLib.Utils.Certificates.Exceptions;

namespace Testing
{
    [TestFixture]
    public class CertificatesTest
    {
        
        [Test]
        [ExpectedException(typeof(CertificateStoreAccessDeniedException))]
        public void CheckInvalidParamsTest()
        {
            // I know, this is kind of twisted, but there's really bad people
            // out there.
            CertificatesHelper.GetCertificatesFrom((CertificateStore) 2);
        }
    }
}
