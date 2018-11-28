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

        public CounterexampleCollection ListarContador(String WorkId)
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

        public Counterexample RetornarContador(String WorkId,String ContadorTitulo)
        {
            Conectar();

            var result = _assistant.GetCounterexample(WorkId, ContadorTitulo);

            return result;
        }
        
        public Counterexample AtualizarContador(String WorkId, String ContadorTitulo)
        {
            Conectar();

            UpdateCounterexample updatedExample = new UpdateCounterexample()
            {
                Text = ContadorTitulo
            };

            var result = _assistant.UpdateCounterexample(WorkId, ContadorTitulo, updatedExample);

            return result;
        }

        public EntityCollection ListarEntidade(String WorkId)
        {
            Conectar();

            var result = _assistant.ListEntities(WorkId);

            return result;
        }

        public Entity CriarEntidade(String WorkId, String Entidade, String Desc)
        {
            CreateEntity entity = new CreateEntity()
            {
                Entity = Entidade,
                Description = Desc
            };

            var result = _assistant.CreateEntity(WorkId, entity);
            return result;
        }

        public Boolean DeletarEntidade(String WorkId, String Entidade)
        {
            var result = _assistant.DeleteEntity(WorkId, Entidade);

            if (result.ResponseJson != "")
            {
                return true;
            }
            return false;
        }

        public EntityExport RetornarEntidade(String WorkId, String Entidade)
        {
            var result = _assistant.GetEntity(WorkId, Entidade);

            return result;
        }

        public Entity AtualizarEntidade(String WorkId, String Entidade, String NEntidade, String DEntidade)
        {
            UpdateEntity updatedEntity = new UpdateEntity()
            {
                Entity = NEntidade,
                Description = DEntidade
            };

            var result = _assistant.UpdateEntity(WorkId, Entidade, updatedEntity);

            return result;
        }

        public ValueCollection ListaVEntidade(String WorkId, String Entidade)
        {
            var result = _assistant.ListValues(WorkId, Entidade);

            return result;
        }

        public Value AdicionarVEntidade(String WorkId, String Entidade, String Valor)
        {
            CreateValue value = new CreateValue()
            {
                Value = Valor
            };

            var result = _assistant.CreateValue(WorkId, Entidade, value);

            return result;
        }

        public Boolean DeletarVEntidade(String WorkId, String Entidade, String Valor)
        {
            var result = _assistant.DeleteValue(WorkId, Entidade, Valor);

            if (result.ResponseJson != "")
            {
                return true;
            }
            return false;
        }

        public ValueExport RetornarVEntidade(String WorkId, String Entidade, String Valor)
        {
            var result = _assistant.GetValue(WorkId, Entidade, Valor);

            return result;
        }

        public Value AtualizarVEntidade(String WorkId, String Entidade, String Valor, String NValor)
        {
            UpdateValue updatedValue = new UpdateValue()
            {
                Value = NValor
            };

            var result = _assistant.UpdateValue(WorkId, Entidade, Valor, updatedValue);

            return result;
        }

        public SynonymCollection ListarSin(String WorkId, String Entidade, String Valor)
        {
            var result = _assistant.ListSynonyms(WorkId, Entidade, Valor);

            return result;
        }

        public Synonym AdicionarSin(String WorkId, String Entidade, String Valor, String NValor)
        {
            CreateSynonym synonym = new CreateSynonym()
            {
                Synonym = NValor
            };

            var result = _assistant.CreateSynonym(WorkId, Entidade, Valor, synonym);

            return result;
        }

        public Boolean DeletarSin(String WorkId, String Entidade, String Valor,String Sin)
        {
            var result = _assistant.DeleteSynonym(WorkId, Entidade, Valor, Sin);

            if (result.ResponseJson != "")
            {
                return true;
            }
            return false;
        }

        public Synonym RetornarSin(String WorkId, String Entidade, String Valor, String Sin)
        {
            var result = _assistant.GetSynonym(WorkId, Entidade, Valor, Sin);

            return result;
        }

        public Synonym AtualizarSin(String WorkId, String Entidade, String Valor, String Sin, String NSin)
        {
            UpdateSynonym updatedSynonym = new UpdateSynonym()
            {
                Synonym = NSin
            };

            var result = _assistant.UpdateSynonym(WorkId, Entidade, Valor, Sin, updatedSynonym);

            return result;
        }

        public IntentCollection ListarInt(String WorkId)
        {
            var result = _assistant.ListIntents(WorkId);

            return result;
        }

        public Intent CriarInt(String WorkId, String Int, String Desc)
        {
            CreateIntent intent = new CreateIntent()
            {
                Intent = Int,
                Description = Desc
            };

            var result = _assistant.CreateIntent(WorkId, intent);

            return result;
        }

        public Boolean DeletarInt(String WorkId, String Int)
        {
            var result = _assistant.DeleteIntent(WorkId, Int);

            if (result.ResponseJson != "")
            {
                return true;
            }
            return false;
        }

        public IntentExport RetornarInt(String WorkId, String Int)
        {
            var result = _assistant.GetIntent(WorkId, Int);

            return result;
        }

        public Intent AtualizarInt(String WorkId, String Int, String Desc)
        {
            UpdateIntent intent = new UpdateIntent()
            {
                Intent = Int,
                Description = Desc
            };

            var result = _assistant.UpdateIntent(WorkId, Int, intent);

            return result;
        }

        public ExampleCollection ListarExe(String WorkId, String Int)
        {
            var result = _assistant.ListExamples(WorkId, Int);

            return result;
        }

        public Example CriarExe(String WorkId, String Int, String Exe)
        {
            CreateExample example = new CreateExample()
            {
                Text = Exe
            };

            var result = _assistant.CreateExample(WorkId, Int, example);

            return result;
        }

        public Boolean DeletarExe(String WorkId, String Int, String Exe)
        {
            var result = _assistant.DeleteExample(WorkId, Int, Exe);

            if (result.ResponseJson != "")
            {
                return true;
            }
            return false;
        }

        public Example RetornarExe(String WorkId, String Int, String Exe)
        {
            var result = _assistant.GetExample(WorkId, Int, Exe);

            return result;
        }

        public Example AtualizarExe(String WorkId, String Int, String Exe, String NExe)
        {
            UpdateExample updatedExample = new UpdateExample()
            {
                Text = NExe
            };

            var result = _assistant.UpdateExample(WorkId, Int, Exe , updatedExample);

            return result;
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

        public LogCollection ListarEventos(String WorkId)
        {
            var result = _assistant.ListLogs(WorkId);

            return result;
        }

    }
}
