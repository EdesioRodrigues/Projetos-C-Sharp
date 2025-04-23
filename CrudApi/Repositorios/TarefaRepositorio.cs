using CrudApi.Data;
using CrudApi.Models;
using CrudApi.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CrudApi.Repositorios
{
    public class TarefaRepositorio : IUTarefasRepositorio
    {
        private readonly SistemasTarefasDBContext _dbContext;
        public TarefaRepositorio(SistemasTarefasDBContext sistemasTarefasDBContext)
        {
            _dbContext = sistemasTarefasDBContext;
        }


        public async Task<TarefaModel> BuscarPorId(int id)
        {
            return await _dbContext.Tarefas
                .Include(x => x.Usuario)
                .FirstOrDefaultAsync(x => x.Id == id);
        }


        public async Task<List<TarefaModel>> BuscarTodasTarefas()
        {
            return await _dbContext.Tarefas
                .Include(x => x.Usuario)
                .ToListAsync();
        }


        public async Task<TarefaModel> Adicionar(TarefaModel tarefa)
        {
            await _dbContext.Tarefas.AddAsync(tarefa);
            await _dbContext.SaveChangesAsync();

            return tarefa;
        }

        public async Task<TarefaModel> Atualizar(TarefaModel tarefa, int id)
        {
            TarefaModel tarefaPorId = await BuscarPorId(id);
            if (tarefaPorId == null)

            {
                throw new Exception($"Usuário para o ID: {id} não foi encontrado.");
            }

            tarefaPorId.Name = tarefa.Name;
            tarefaPorId.Descricao = tarefa.Descricao;
            tarefaPorId.Status = tarefa.Status;
            tarefaPorId.UsuarioId = tarefa.UsuarioId;

            _dbContext.Tarefas.Update(tarefaPorId);
            await _dbContext.SaveChangesAsync();

            return tarefaPorId;
        }

            public async Task<bool> Apagar(int id)
            {
                TarefaModel tarefaPorId = await BuscarPorId(id);
                if (tarefaPorId == null)

                {
                    throw new Exception($"A tarefa para o ID: {id} não foi encontrado.");
                }

            _dbContext.Tarefas.Remove(tarefaPorId);
            await _dbContext.SaveChangesAsync();

            return true;
            }

    }
}
