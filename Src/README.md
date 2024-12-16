# Fase 01: Planejamento 

### 1. Definir os Requisitos do sistema

- Quais tipos de ameaça o sistema deve detectar?
- Escalabilidade necessária para suportar o tráfego de rede.
- Tipo de alertas e relatórios esperados (tempo real, histórico, etc.).

### 2. Escolher Ferramentas e Tecnologias

- Backend: dotnet.
- Captura de pacotes: PacketDotNet. 
- Análise de tráfego: ML.NET e regras baseadas em assinaturas. 
- Monitoramento: Elastic Stack (ELK).
- Infraestrutura: Azure Kubernets Service (AKS).

### 3. Modelar o Domínio

- Definir entidades (ex: Packet, Netwoking).
- Identificar agregados e objetos de valor (ex: IPAdress, Port).
- Planejar eventos de domínio (ex: SuspiciousTrafficDetected).


# Fase 1.1: Planejamento - Detectar DDoS

1. O que é um ataque DDoS?
   2. Um ataque DDoS ocorre quando múltiplas fontes enviam grandes quantidades de requisições para um servidor, consumindo seus recursos e impedindo que usuários legítimos acessem o serviço.
   3. Tipos comuns de ataques DDoS
      4. UDP Flood: Grandes volumes de pacotes UDP para portas arbitrárias.
      5. SYN Flood: Requisições TCP SYN sem completar o handshake.
      6. HTTP Flood: Requisições legítimas, mas em grande escala.
      7. Amplifição (Ex: DNS): Uso de servidores intermediários para amplificar o tráfego
8. Como Detectar DDoS no sistema?
   9. Sinais de DDoS:
      10. Picos anormais de tráfego em curtos períodos.
      11. Alta frequência de pacotes de um ou vários IPs.
      12. Muitas conexões incompletas (SYN Flood).
      13. Requisições repetitivas para o mesmo recurso (HTTP Flood).
   14. Metricas úteis:
       15. Taxa de pacotes por segundo (PPS).
       16. Taxa de conexões por segundo (CPS).
       17. Volume de dados (Mbps ou Gbps).
       18. Distribuição de IPs e portas.
   19. 