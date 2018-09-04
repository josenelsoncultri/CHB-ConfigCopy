using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.IO;

namespace CHB_ConfigCopy.Classes
{
    public class ProcessadorXml
    {
        public void PrepararConfiguracoes()
        {
            if (File.Exists(Defaults.CaminhoConfig()))
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(Defaults.CaminhoConfig());
                xmlDocument.PreserveWhitespace = true;

                xmlDocument.DocumentElement.RemoveAll();

                XmlAttribute defaultProfileName = xmlDocument.CreateAttribute("name");
                defaultProfileName.Value = "GeneXus 15";

                XmlElement defaultProfile = xmlDocument.CreateElement("DefaultProfile");
                defaultProfile.Attributes.Append(defaultProfileName);
                xmlDocument.DocumentElement.AppendChild(defaultProfile);

                XmlElement profiles = xmlDocument.CreateElement("Profiles");
                XmlElement profile = xmlDocument.CreateElement("Profile");
                profile.Attributes.Append(defaultProfileName);
                foreach (XmlNode n in xmlDocument.DocumentElement.ChildNodes)
                {
                    profile.AppendChild(n);
                }

                profiles.AppendChild(profile);

                xmlDocument.DocumentElement.AppendChild(profiles);

                xmlDocument.Save(Defaults.CaminhoConfig());
            }
        }

        public bool AdicionarPerfil(string nomePerfil)
        {
            bool retorno = false;

            try
            {
                if (Validar(nomePerfil))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(Defaults.CaminhoConfig());
                    xmlDoc.PreserveWhitespace = true;

                    XmlAttribute name = xmlDoc.CreateAttribute("name");
                    name.Value = nomePerfil;
                    XmlElement profile = xmlDoc.CreateElement("Profile");
                    profile.Attributes.Append(name);

                    profile.InnerXml = Defaults.ConfiguracoesPadrao();

                    xmlDoc.DocumentElement.SelectSingleNode("/Settings/Profiles").AppendChild(profile);

                    xmlDoc.Save(Defaults.CaminhoConfig());

                    retorno = true;
                }
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        private bool Validar(string nomePerfil)
        {
            bool retorno = true;
            string mensagem = "Erros ao validar a criação do novo perfil:\n";

            if (nomePerfil.Trim() == "")
            {
                mensagem += "\nO nome do perfil não pode ser vazio!";
                retorno = false;
            }

            if (nomePerfil.Trim() != "")
            {
                if (this.ObterPerfis().IndexOf(nomePerfil) > 0)
                {
                    mensagem += "\nO perfil \"" + nomePerfil + "\" já existe!";
                    retorno = false;
                }
            }

            return retorno;
        }

        private List<string> ObterPerfis()
        {
            List<string> retorno = new List<string>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(Defaults.CaminhoConfig());

            foreach (XmlNode n in xmlDoc.SelectNodes("/Settings/Profiles/Profile"))
            {
                retorno.Add(n.Attributes["name"].Value.ToString().Trim());
            }

            return retorno;
        }
    }
}
