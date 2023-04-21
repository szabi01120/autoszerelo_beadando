CREATE XML SCHEMA COLLECTION [dbo].[schema_collection_Performance Counters Collector Type]
    AS N'<xsd:schema xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:t="DataCollectorType" targetNamespace="DataCollectorType">
  <xsd:element name="PerformanceCountersCollector">
    <xsd:complexType>
      <xsd:complexContent>
        <xsd:restriction base="xsd:anyType">
          <xsd:sequence>
            <xsd:element name="PerformanceCounters" minOccurs="0" maxOccurs="unbounded">
              <xsd:complexType>
                <xsd:complexContent>
                  <xsd:restriction base="xsd:anyType">
                    <xsd:sequence />
                    <xsd:attribute name="Objects" type="xsd:string" use="required" />
                    <xsd:attribute name="Counters" type="xsd:string" use="required" />
                    <xsd:attribute name="Instances" type="xsd:string" />
                  </xsd:restriction>
                </xsd:complexContent>
              </xsd:complexType>
            </xsd:element>
          </xsd:sequence>
          <xsd:attribute name="StoreLocalizedCounterNames" type="xsd:boolean" default="false" />
        </xsd:restriction>
      </xsd:complexContent>
    </xsd:complexType>
  </xsd:element>
</xsd:schema>';

