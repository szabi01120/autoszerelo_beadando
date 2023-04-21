CREATE XML SCHEMA COLLECTION [dbo].[schema_collection_Generic SQL Trace Collector Type]
    AS N'<xsd:schema xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:t="DataCollectorType" targetNamespace="DataCollectorType">
  <xsd:element name="SqlTraceCollector">
    <xsd:complexType>
      <xsd:complexContent>
        <xsd:restriction base="xsd:anyType">
          <xsd:sequence>
            <xsd:element name="Events">
              <xsd:complexType>
                <xsd:complexContent>
                  <xsd:restriction base="xsd:anyType">
                    <xsd:sequence>
                      <xsd:element name="EventType" minOccurs="0" maxOccurs="unbounded">
                        <xsd:complexType>
                          <xsd:complexContent>
                            <xsd:restriction base="xsd:anyType">
                              <xsd:sequence>
                                <xsd:element name="Event" maxOccurs="unbounded">
                                  <xsd:complexType>
                                    <xsd:complexContent>
                                      <xsd:restriction base="xsd:anyType">
                                        <xsd:sequence />
                                        <xsd:attribute name="id" type="xsd:unsignedByte" use="required" />
                                        <xsd:attribute name="name" type="xsd:string" use="required" />
                                        <xsd:attribute name="columnslist" type="xsd:string" />
                                      </xsd:restriction>
                                    </xsd:complexContent>
                                  </xsd:complexType>
                                </xsd:element>
                              </xsd:sequence>
                              <xsd:attribute name="id" type="xsd:unsignedByte" />
                              <xsd:attribute name="name" type="xsd:string" use="required" />
                            </xsd:restriction>
                          </xsd:complexContent>
                        </xsd:complexType>
                      </xsd:element>
                    </xsd:sequence>
                  </xsd:restriction>
                </xsd:complexContent>
              </xsd:complexType>
            </xsd:element>
            <xsd:element name="Filters">
              <xsd:complexType>
                <xsd:complexContent>
                  <xsd:restriction base="xsd:anyType">
                    <xsd:sequence>
                      <xsd:element name="Filter" minOccurs="0" maxOccurs="unbounded">
                        <xsd:complexType>
                          <xsd:complexContent>
                            <xsd:restriction base="xsd:anyType">
                              <xsd:sequence />
                              <xsd:attribute name="columnid" type="xsd:unsignedByte" use="required" />
                              <xsd:attribute name="columnname" type="xsd:string" use="required" />
                              <xsd:attribute name="logical_operator" type="xsd:string" use="required" />
                              <xsd:attribute name="comparison_operator" type="xsd:string" use="required" />
                              <xsd:attribute name="value" type="xsd:string" use="required" />
                            </xsd:restriction>
                          </xsd:complexContent>
                        </xsd:complexType>
                      </xsd:element>
                    </xsd:sequence>
                  </xsd:restriction>
                </xsd:complexContent>
              </xsd:complexType>
            </xsd:element>
          </xsd:sequence>
          <xsd:attribute name="use_default" type="xsd:boolean" />
        </xsd:restriction>
      </xsd:complexContent>
    </xsd:complexType>
  </xsd:element>
</xsd:schema>';

