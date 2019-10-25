using System.Xml.Serialization;
public class Schemes_FFOMS
{ 
    //Соответствует федеральному справочнику F003
    //Версия 1.0.1
    public class f003_schema_1_0_1
    {
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class packet : XML_abstract_file
        {

            private medCompany[] medCompanyField;

            private string versionField;

            private string dateField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("medCompany", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public medCompany[] medCompany
            {
                get
                {
                    return this.medCompanyField;
                }
                set
                {
                    this.medCompanyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class medCompany
        {

            private string tf_okatoField;

            private string mcodField;

            private string nam_mopField;

            private string nam_mokField;

            private string innField;

            private string ogrnField;

            private string kPPField;

            private string okopfField;

            private string vedpriField;

            private string orgField;

            private string fam_rukField;

            private string im_rukField;

            private string ot_rukField;

            private string phoneField;

            private string faxField;

            private string e_mailField;

            private string wwwField;

            private string d_editField;

            private jurAddress jurAddressField;

            private doc[] docField;

            private medInclude medIncludeField;

            private medAdvice[] medAdviceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string tf_okato
            {
                get
                {
                    return this.tf_okatoField;
                }
                set
                {
                    this.tf_okatoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string mcod
            {
                get
                {
                    return this.mcodField;
                }
                set
                {
                    this.mcodField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string nam_mop
            {
                get
                {
                    return this.nam_mopField;
                }
                set
                {
                    this.nam_mopField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string nam_mok
            {
                get
                {
                    return this.nam_mokField;
                }
                set
                {
                    this.nam_mokField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string inn
            {
                get
                {
                    return this.innField;
                }
                set
                {
                    this.innField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string Ogrn
            {
                get
                {
                    return this.ogrnField;
                }
                set
                {
                    this.ogrnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string KPP
            {
                get
                {
                    return this.kPPField;
                }
                set
                {
                    this.kPPField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string okopf
            {
                get
                {
                    return this.okopfField;
                }
                set
                {
                    this.okopfField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string vedpri
            {
                get
                {
                    return this.vedpriField;
                }
                set
                {
                    this.vedpriField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string org
            {
                get
                {
                    return this.orgField;
                }
                set
                {
                    this.orgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string fam_ruk
            {
                get
                {
                    return this.fam_rukField;
                }
                set
                {
                    this.fam_rukField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string im_ruk
            {
                get
                {
                    return this.im_rukField;
                }
                set
                {
                    this.im_rukField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string ot_ruk
            {
                get
                {
                    return this.ot_rukField;
                }
                set
                {
                    this.ot_rukField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string phone
            {
                get
                {
                    return this.phoneField;
                }
                set
                {
                    this.phoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string fax
            {
                get
                {
                    return this.faxField;
                }
                set
                {
                    this.faxField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string e_mail
            {
                get
                {
                    return this.e_mailField;
                }
                set
                {
                    this.e_mailField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string www
            {
                get
                {
                    return this.wwwField;
                }
                set
                {
                    this.wwwField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string d_edit
            {
                get
                {
                    return this.d_editField;
                }
                set
                {
                    this.d_editField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("jurAddress", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public jurAddress jurAddress
            {
                get
                {
                    return this.jurAddressField;
                }
                set
                {
                    this.jurAddressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("doc", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public doc[] doc
            {
                get
                {
                    return this.docField;
                }
                set
                {
                    this.docField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("medInclude", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public medInclude medInclude
            {
                get
                {
                    return this.medIncludeField;
                }
                set
                {
                    this.medIncludeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("medAdvice", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public medAdvice[] medAdvice
            {
                get
                {
                    return this.medAdviceField;
                }
                set
                {
                    this.medAdviceField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class jurAddress
        {

            private string index_jField;

            private string addr_jField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string index_j
            {
                get
                {
                    return this.index_jField;
                }
                set
                {
                    this.index_jField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string addr_j
            {
                get
                {
                    return this.addr_jField;
                }
                set
                {
                    this.addr_jField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class doc
        {

            private string n_docField;

            private string d_startField;

            private string date_eField;

            private string d_termField;

            private mp[] mpField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string n_doc
            {
                get
                {
                    return this.n_docField;
                }
                set
                {
                    this.n_docField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string d_start
            {
                get
                {
                    return this.d_startField;
                }
                set
                {
                    this.d_startField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string date_e
            {
                get
                {
                    return this.date_eField;
                }
                set
                {
                    this.date_eField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string d_term
            {
                get
                {
                    return this.d_termField;
                }
                set
                {
                    this.d_termField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("mp", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
            public mp[] mp
            {
                get
                {
                    return this.mpField;
                }
                set
                {
                    this.mpField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class mp
        {

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class medInclude
        {

            private string d_beginField;

            private string d_endField;

            private string name_eField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string d_begin
            {
                get
                {
                    return this.d_beginField;
                }
                set
                {
                    this.d_beginField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string d_end
            {
                get
                {
                    return this.d_endField;
                }
                set
                {
                    this.d_endField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string name_e
            {
                get
                {
                    return this.name_eField;
                }
                set
                {
                    this.name_eField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class medAdvice
        {

            private string yEAR_WORKField;

            private string dUVEDField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string YEAR_WORK
            {
                get
                {
                    return this.yEAR_WORKField;
                }
                set
                {
                    this.yEAR_WORKField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string DUVED
            {
                get
                {
                    return this.dUVEDField;
                }
                set
                {
                    this.dUVEDField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class NewDataSet
        {

            private packet[] itemsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("packet")]
            public packet[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }
        }
    }
}
