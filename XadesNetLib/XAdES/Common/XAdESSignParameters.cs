﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using XadesNetLib.Common;

namespace XadesNetLib.Xades.Common
{
    public class XadesSignParameters
    {
        public string InputPath { get; set; }
        public XmlDocument InputXml { get; set; }
        public string OutputPath { get; set; }
        public bool IncludeCertificateInSignature { get; set; }

        public X509Certificate2 SignatureCertificate { get; set; }

        private List<XmlPropertyDescriptor> _properties = new List<XmlPropertyDescriptor>();
        public List<XmlPropertyDescriptor> Properties
        {
            get { return _properties; }
            set { _properties = value; }
        }

        private List<Converter<XmlDocument, XmlElement>> _propertyBuilders = new List<Converter<XmlDocument, XmlElement>>();
        public List<Converter<XmlDocument, XmlElement>> PropertyBuilders
        {
            get { return _propertyBuilders; }
            set { _propertyBuilders = value; }
        }
    }
}