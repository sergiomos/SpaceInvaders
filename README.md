# 🚀 Space Invaders - Jogo


<img width="300" height="350" alt="ChatGPT Image 23 de set  de 2025, 00_57_26" src="https://github.com/user-attachments/assets/df197580-7331-4529-b73a-7bbb7c563edb" />

## 🎮 Descrição
Space Invaders é um jogo clássico de tiro espacial onde o jogador controla uma nave e deve destruir todos os alienígenas antes que eles cheguem à base da tela. O jogo possui diferentes tipos de inimigos, incluindo naves comuns e uma nave chefe, cada uma com comportamento próprio.

O objetivo é **sobreviver e acumular pontos** destruindo os alienígenas.

---

## 🕹 Gameplay

### Controles do Player
- **➡ Seta para direita** → Move o player para a direita.  
- **⬅ Seta para esquerda** → Move o player para a esquerda.  
- **⎵ Espaço** → Dispara um míssil.

> Cada míssil criado pelo player se move verticalmente até atingir um inimigo ou a parede.  
> - Se atingir um inimigo, ambos são removidos do jogo.  
> - Se atingir a parede, o míssil é removido.

### Ações das naves inimigas

**Naves comuns:**
- Movem-se horizontalmente 10 passos, incrementando ou decrementando a posição X.  
- Descendem 5 unidades a cada ciclo.  
- Atiram míssil aleatoriamente.  
- Se tocarem a parede inferior, o jogo termina.  
- Cada míssil inimigo decrementa Y a cada passo e pode atingir o player, reduzindo sua vida.

**Nave chefe:**
- Aparece aleatoriamente a cada 30~50 segundos no canto superior esquerdo.  
- Move-se horizontalmente 5 unidades por passo.  
- Desaparece ao chegar no canto superior direito.

---

## ⚡ Elementos Formais

- **Single-player:** O jogador controla uma única nave.  
- **Objetivo:** Destruir todos os alienígenas na tela.  
- **Regras principais:**  
  - Jogador não pode ultrapassar os limites da tela.  
  - Alienígenas se movem de um lado para o outro no topo da tela.  
  - Mísseis podem ser disparados pelo player e pelos inimigos.  
  - O jogo apresenta níveis de dificuldade progressivos.

---

## 🏆 Recursos

- **Vidas:** 3  
- **Pontos:** Inicia com 0. Cada tipo de inimigo dá pontuação diferente:

| Tipo de Inimigo | Pontos |
|-----------------|--------|
| Tipo 1          | 10     |
| Tipo 2          | 20     |
| Tipo 3          | 30     |
| Chefe           | 50     |

- **Mísseis infinitos** para player e inimigos

---

## 🚧 Limites do jogo
- Ambiente virtual  
- Paredes limitam movimento  
- Quantidade de vidas define quanto o jogador pode continuar

---

## 🏁 Condições de término
- Todos os alienígenas são destruídos → **Vitória** ✅
 <img width="300" height="350" alt="Vitória no Jogo Retro" src="https://github.com/user-attachments/assets/5146e90f-6f51-4799-9154-afad882f456a" />

- Player perde todas as vidas → **Derrota** ❌
 <img width="300" height="350" alt="ChatGPT Image 23 de set  de 2025, 02_26_32" src="https://github.com/user-attachments/assets/2a9cc4ff-cfe3-4c47-854f-c0eba1732261" />


---

## 📋 Procedimentos
1. Pressione a seta para direita para mover o player para a direita.  
2. Pressione a seta para esquerda para mover o player para a esquerda.  
3. Pressione espaço para disparar mísseis.

---

## 🔧 Pontos de melhoria
- Implementar **efeitos sonoros** para tiros e explosões.  
- Criar **animações** para explosões dos alienígenas.  
- Adicionar **ranking de pontuação**.

---

## 🖼 Feito Por:
- Sérgio Martins

## 💡 Sugestões de Jogabilidade

O universo de Space Invaders está sempre em expansão! 🌌  
Se você tiver ideias para **novos inimigos, power-ups, fases ou melhorias**, compartilhe com a gente!  

Sinta-se à vontade para abrir **issues** ou enviar **pull requests** — juntos, podemos tornar o jogo ainda mais épico! 🚀👾

