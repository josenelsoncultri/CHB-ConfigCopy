using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml;

namespace CHB_ConfigCopy.Classes
{
    public class Defaults
    {
        public static void CriarArquivo()
        {
            string xml = "";

            xml += "<Settings>";
            xml += "	<DefaultProfile value=\"GeneXus 15\" />";
            xml += "	<Profiles>";
            xml += "		<Profile name=\"GeneXus 15\">";
            xml += ConfiguracoesPadrao();
            xml += "		</Profile>";
            xml += "	</Profiles>";
            xml += "</Settings>";

            if (!File.Exists(Defaults.CaminhoConfig()))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xml);
                xmlDoc.PreserveWhitespace = true;

                xmlDoc.Save(Defaults.CaminhoConfig());                
            }            
        }

        public static string ConfiguracoesPadrao()
        {
            string xml = "";

            xml += @"		  <CaminhoRaiz>\\serverchbweb15\sites\</CaminhoRaiz>";
            xml += @"		  <Oracle>C:\inetpub\wwwroot\chbwebora15\</Oracle>";
            xml += @"		  <Post>C:\inetpub\wwwroot\chbwebpos15\</Post>";
            xml += @"		  <SQL>C:\inetpub\wwwroot\chbwebsql15\</SQL>";
            xml += "		  <SessionState>tcpip=serverchb02:42424;</SessionState>";
            xml += "		  <CopiarWebConfig>True</CopiarWebConfig>";
            xml += "		  <CopiarClientExeConfig>True</CopiarClientExeConfig>";
            xml += "		  <FecharCHBConfigCopy>True</FecharCHBConfigCopy>";
            xml += "		  <ModificarSessionState>True</ModificarSessionState>";
            xml += "		  <DesabilitarCache>False</DesabilitarCache>";

            return xml;
        }

        public static string CaminhoConfig()
        {
            return System.Windows.Forms.Application.StartupPath + @"\Settings.xml";
        }
    }
}
