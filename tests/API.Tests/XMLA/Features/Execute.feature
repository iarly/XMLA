Feature: Execute
	QUANDO executar uma consulta XMLA
	EU QUERO que sejam retornadas os dados requeridos
	PARA QUE eu possa analisar as informações que desejo

@mytag
Scenario: Make a consult for an unique measure
	Given I am the user "admin" with the password "1234"
	When I make an execute command with the follow content
	"""
	<?xml version="1.0"?>
	<SOAP-ENV:Envelope>
		<SOAP-ENV:Body>
			<Execute xmlns="urn:schemas-microsoft-com:xml-analysis" SOAP-ENV:encodingStyle="http://schemas.xmlsoap.org/soap/encoding/">
				<Command>
					<Statement>
						SELECT [KPIs].[My Success KPI].[Target] ON Columns FROM [My Cube]
					</Statement>
				</Command>
			</Execute>
		</SOAP-ENV:Body>
	</SOAP-ENV:Envelope>
    """
	Then the result should be like
	"""
	<?xml version="1.0"?>
	<SOAP-ENV:Envelope xmlns:SOAP-ENV="http://schemas.xmlsoap.org/soap/envelope/" SOAP-ENV:encodingStyle="http://schemas.xmlsoap.org/soap/encoding/">
		<SOAP-ENV:Body>  
			<m:ExecuteResponse xmlns:m="urn:schemas-microsoft-com:xml-analysis">  
				<m:return SOAP-ENV:encodingStyle="http://schemas.xmlsoap.org/soap/encoding/">
					<root>
						<xsd:schema xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xars="urn:schemas-microsoft-com:xars">
							<!—The schema for the data goes here. -- >
						</xsd:schema>
						<!—The data in MDDataSet format goes here. -- >
					</root>  
				</m:return>
			</m:ExecuteResponse>
		</SOAP-ENV:Body>
	</SOAP-ENV:Envelope>
	"""
