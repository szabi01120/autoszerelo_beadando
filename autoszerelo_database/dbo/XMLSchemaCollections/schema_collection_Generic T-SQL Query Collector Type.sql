CREATE XML SCHEMA COLLECTION [dbo].[schema_collection_Generic T-SQL Query Collector Type]
    AS N'<xsd:schema xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:t="DataCollectorType" targetNamespace="DataCollectorType">
  <xsd:element name="TSQLQueryCollector">
    <xsd:complexType>
      <xsd:complexContent>
        <xsd:restriction base="xsd:anyType">
          <xsd:sequence>
            <xsd:element name="Query" maxOccurs="unbounded">
              <xsd:complexType>
                <xsd:complexContent>
                  <xsd:restriction base="xsd:anyType">
                    <xsd:sequence>
                      <xsd:element name="Value" type="xsd:string" />
                      <xsd:element name="OutputTable" type="xsd:string" />
                    </xsd:sequence>
                  </xsd:restriction>
                </xsd:complexContent>
              </xsd:complexType>
            </xsd:element>
            <xsd:element name="Databases" minOccurs="0">
              <xsd:complexType>
                <xsd:complexContent>
                  <xsd:restriction base="xsd:anyType">
                    <xsd:sequence>
                      <xsd:element name="Database" type="xsd:string" minOccurs="0" maxOccurs="unbounded" />
                    </xsd:sequence>
                    <xsd:attribute name="UseSystemDatabases" type="xsd:boolean" />
                    <xsd:attribute name="UseUserDatabases" type="xsd:boolean" />
                  </xsd:restriction>
                </xsd:complexContent>
              </xsd:complexType>
            </xsd:element>
          </xsd:sequence>
        </xsd:restriction>
      </xsd:complexContent>
    </xsd:complexType>
  </xsd:element>
</xsd:schema>';

