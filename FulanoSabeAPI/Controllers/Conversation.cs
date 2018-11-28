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

         public Workspace CriarAreaTrabalho(String nome, String descricao,String linguagem)
        {

            TokenOptions iamAssistantTokenOptions = new TokenOptions()
            {
                IamApiKey = "QUENUlKk8Pns1rTEgXGoZ7nzSst_A_v7H_fDOzyh4W7i",
                ServiceUrl = "https://gateway.watsonplatform.net/assistant/api"
            };

            AssistantService _assistant = new AssistantService(iamAssistantTokenOptions, "2018-09-20");


            CreateWorkspace workspace = new CreateWorkspace()
            {
                Name = nome,
                Description = descricao,
                Language = linguagem
            };

            Workspace response = _assistant.CreateWorkspace(workspace);

            return response;
        }


    }
}
