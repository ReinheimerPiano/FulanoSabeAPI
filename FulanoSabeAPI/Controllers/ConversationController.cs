using IBM.WatsonDeveloperCloud.Assistant.v1;
using IBM.WatsonDeveloperCloud.Assistant.v1.Model;
using IBM.WatsonDeveloperCloud.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FulanoSabeAPI.Models
{
    public class Conversation
    {
        public AssistantService _assistant;

        public void Conectar()
        {
            TokenOptions iamAssistantTokenOptions = new TokenOptions()
            {
                IamApiKey = "QUENUlKk8Pns1rTEgXGoZ7nzSst_A_v7H_fDOzyh4W7i",
                ServiceUrl = "https://gateway.watsonplatform.net/assistant/api"
            };

            _assistant = new AssistantService(iamAssistantTokenOptions, "2018-09-20");

        }
         public Workspace CriarAreaTrabalho(String nome, String descricao,String linguagem)
        {
            Conectar();
                                 
            CreateWorkspace workspace = new CreateWorkspace()
            {
                Name = nome,
                Description = descricao,
                Language = linguagem
            };

            Workspace response = _assistant.CreateWorkspace(workspace);

            return response;
        }

        public WorkspaceCollection ListarAreaTrabalho()
        {
            Conectar();

            var result = _assistant.ListWorkspaces();

            return result;
        }

        public Boolean DeletarAreaTrabalho(String id)
        {
            Conectar();

            var result = _assistant.DeleteWorkspace(id);

            if (result.ResponseJson != "")
            {
                return true;
            }
            return false;
        }


    }
}
