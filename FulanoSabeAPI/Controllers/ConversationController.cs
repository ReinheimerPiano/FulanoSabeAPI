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

        public CounterexampleCollection ListarContextos(String WorkId)
        {
            Conectar();

            var result = _assistant.ListCounterexamples(WorkId);

            return result;
        }

        public Counterexample CriarContador(String WorkId, String ContadorTitulo)
        {
            Conectar();

            CreateCounterexample example = new CreateCounterexample()
            {
                Text = ContadorTitulo
            };

            var result = _assistant.CreateCounterexample(WorkId, example);

            return result;
        }

        public Boolean DeletarContador(String WorkId, String ContadorTitulo)
        {
            Conectar();

            var result = _assistant.DeleteCounterexample(WorkId, ContadorTitulo);

            if (result.ResponseJson != "")
            {
                return true;
            }
            return false;
        }




        public MessageResponse EnviarMenssagem(String Msg,String WorkId, Boolean Continua, MessageResponse result)
        {
            if (Continua)
            {
                MessageRequest messageRequest0 = new MessageRequest()
                {
                    Input = new InputData()
                    {
                        Text = Msg
                    }
                };

                var result0 = _assistant.Message(WorkId, messageRequest0);

                return result0;
            } else
            {

                MessageRequest messageRequest1 = new MessageRequest()
                {
                    Input = new InputData()
                    {
                        Text = Msg
                  },
                    Context = result.Context
                };

                var result1 = _assistant.Message(WorkId, messageRequest1);

                return result1;
            }

        }

    }
}
