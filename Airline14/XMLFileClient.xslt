<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="@* | node()">
        <xsl:copy>
            <xsl:apply-templates select="node()"/>
        </xsl:copy>
		<html>

<head/>

<body>
	<div>		
		<span style="list-style-type: disk">
		<xsl:for-each select="/DataSet1/Passengers">
			<li>
			<xsl:value-of select="ID"/>
			<br/>
			<xsl:value-of select="PersonalInfo"/>
			<br/>
			<xsl:value-of select="PassportInfo"/>
			<br/>
			</li>
		</xsl:for-each>
	</span>
	</div>
</body>
</html>
	</xsl:template>
</xsl:stylesheet>
