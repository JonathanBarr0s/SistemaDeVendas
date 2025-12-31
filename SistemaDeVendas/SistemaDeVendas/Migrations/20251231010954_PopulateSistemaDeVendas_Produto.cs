using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeVendas.Migrations
{
	/// <inheritdoc />
	public partial class PopulateSistemaDeVendas_Produto : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.InsertData(
				table: "SistemaDeVendas_Produto",
				columns: new[]
				{
					"Nome",
					"Descricao",
					"Preco_Unitario",
					"Quantidade_Estoque",
					"Link_Foto",
				},
				values: new object[,]
				{
					{
						"Notebook Dell",
						"Notebook Dell Inspiron 15 desenvolvido para oferecer alto desempenho em tarefas do dia a dia, estudos e trabalho profissional. Possui excelente acabamento, teclado confortável, tela ampla e recursos modernos que garantem produtividade, estabilidade e ótima experiência de uso em aplicações corporativas e pessoais.",
						3500.00m,
						15,
						"https://github.com/user-attachments/assets/78741a82-4656-4088-8d8b-9bc370b301f4"
					},
					{
						"Mouse Logitech",
						"Mouse sem fio Logitech com design ergonômico, alta precisão e excelente durabilidade. Ideal para uso prolongado em escritórios ou home office, oferece conexão estável, resposta rápida e conforto para longas jornadas de trabalho ou estudo.",
						120.90m,
						50,
						"https://github.com/user-attachments/assets/f0ba0fcc-23dc-43e3-8ba5-2871f485ed8e"
					},
					{
						"Teclado Mecânico",
						"Teclado mecânico RGB desenvolvido para usuários exigentes que buscam desempenho, conforto e durabilidade. Possui switches responsivos, iluminação personalizável e construção reforçada, sendo ideal tanto para jogos quanto para digitação profissional.",
						450.00m, 
						20,
						"https://github.com/user-attachments/assets/ba8201e0-0679-49a1-b28b-7b55849d3c3b"
					},
					{
						"Monitor 24\"",
						"Monitor Full HD de 24 polegadas com excelente qualidade de imagem, cores vivas e amplo ângulo de visão. Indicado para trabalho, estudo e entretenimento, proporciona conforto visual e produtividade em longos períodos de uso.",
						899.99m,
						12,
						"https://github.com/user-attachments/assets/88e68c3a-4d16-4221-aa32-ed04ebd0a1d6"
					},
					{
						"Cabo HDMI",
						"Cabo HDMI 2.0 com 2 metros de comprimento, ideal para transmissão de áudio e vídeo em alta definição. Compatível com diversos dispositivos, garante sinal estável, qualidade superior e durabilidade para uso doméstico ou profissional.",
						35.50m,
						100,
						"https://github.com/user-attachments/assets/4b8878ac-27a0-47bf-8d69-aa39c8dfca86"
					},
					{
						"SSD 500GB",
						"SSD NVMe de 500GB com alta velocidade de leitura e gravação, proporcionando inicialização rápida do sistema e carregamento ágil de aplicativos. Ideal para melhorar significativamente o desempenho de computadores e notebooks.",
						399.90m,
						25,
						"https://github.com/user-attachments/assets/6e4b9ba1-cb34-4b5d-aea0-7660499a116c"
					},
					{
						"Fonte 600W",
						"Fonte ATX de 600W com certificação 80 Plus, garantindo eficiência energética, estabilidade e segurança para os componentes do computador. Indicada para setups intermediários e avançados, oferecendo proteção e desempenho confiável.",
						520.00m,
						10,
						"https://github.com/user-attachments/assets/cf08656a-7c28-4c61-83ba-cd43e7daf2e7"
					},
					{
						"Headset Gamer",
						"Headset gamer com microfone integrado, som de alta qualidade e design confortável. Ideal para jogos online, chamadas e streaming, proporciona excelente isolamento acústico e comunicação clara durante longas sessões de uso.",
						299.99m,
						18,
						"https://github.com/user-attachments/assets/2d120f3c-c238-4dc5-95f9-25c95c9b0995"
					},
					{
						"Pendrive 64GB",
						"Pendrive USB 3.0 de 64GB com alta velocidade de transferência e design compacto. Ideal para armazenamento e transporte de arquivos importantes, oferece praticidade, confiabilidade e compatibilidade com diversos dispositivos.",
						59.90m,
						40,
						"https://github.com/user-attachments/assets/68d947ee-73bf-4179-a699-5f36d29379eb"
					},
					{
						"Cadeira Gamer",
						"Cadeira gamer ergonômica desenvolvida para proporcionar conforto e postura adequada durante longos períodos de uso. Possui ajustes de altura, inclinação e apoio lombar, sendo ideal para jogos, estudos ou trabalho.",
						1200.00m,
						5,
						"https://github.com/user-attachments/assets/e6ec6715-65c8-4029-9bee-7e1e3f2f20d9"
					},
					{
						"Webcam Full HD",
						"Webcam Full HD com excelente qualidade de imagem, ideal para videoconferências, aulas online e transmissões ao vivo. Possui foco automático, microfone integrado e fácil instalação em notebooks e monitores.",
						210.00m,
						22,
						"https://github.com/user-attachments/assets/7edaff05-bc0a-4123-89a4-57f6f4d60e85"
					},
					{
						"Impressora Multifuncional",
						"Impressora multifuncional com funções de impressão, cópia e digitalização. Ideal para uso doméstico ou pequenos escritórios, oferece boa qualidade de impressão, economia de tinta e facilidade de uso no dia a dia.",
						950.00m,
						8,
						"https://github.com/user-attachments/assets/97426627-f58c-4d16-81de-a6acbb06133e"
					},
					{
						"Roteador Wi-Fi",
						"Roteador Wi-Fi de alto desempenho com ampla cobertura e conexão estável. Ideal para residências e escritórios, suporta múltiplos dispositivos conectados simultaneamente, garantindo velocidade e segurança na navegação.",
						320.00m,
						14,
						"https://github.com/user-attachments/assets/c362cea9-7f8a-40dc-a2b8-dfe2fee3a10a"
					},
					{
						"Placa de Vídeo",
						"Placa de vídeo dedicada desenvolvida para oferecer alto desempenho gráfico em jogos, edição de vídeos e aplicações profissionais. Possui excelente capacidade de processamento e suporte a tecnologias modernas.",
						2800.00m,
						6,
						"https://github.com/user-attachments/assets/159667fc-21f7-463b-8048-3ba7f94feb74"
					},
					{
						"HD Externo 1TB",
						"HD externo de 1TB com alta capacidade de armazenamento e fácil portabilidade. Ideal para backups, armazenamento de arquivos pessoais e profissionais, garantindo segurança e praticidade no transporte de dados.",
						420.00m,
						17,
						"https://github.com/user-attachments/assets/ec7b986c-a984-4df8-8256-f779b3b07a05"
					},
					{
						"Tablet",
						"Tablet moderno com tela de alta resolução, ótimo desempenho e bateria de longa duração. Ideal para estudos, leitura, entretenimento e tarefas cotidianas, oferecendo mobilidade e versatilidade para o usuário.",
						1500.00m,
						9,
						"https://github.com/user-attachments/assets/57cf2747-6693-4fcd-87af-a02f3a2694fa"
					},
					{
						"Smartphone",
						"Smartphone com design moderno, excelente desempenho e câmera de alta qualidade. Ideal para comunicação, redes sociais, trabalho e entretenimento, oferecendo fluidez, segurança e recursos avançados.",
						2200.00m,
						11,
						"https://github.com/user-attachments/assets/3e8306fc-a58c-4f10-a23b-3f181e73a643"
					},
					{
						"Mousepad Gamer",
						"Mousepad gamer de alta qualidade com superfície otimizada para precisão e controle. Possui base antiderrapante e material resistente, garantindo estabilidade e desempenho em jogos e atividades profissionais.",
						89.90m,
						30,
						"https://github.com/user-attachments/assets/134ec00f-ab04-4074-a78b-28373d88c1dc"
					},
					{
						"Estabilizador",
						"Estabilizador de tensão desenvolvido para proteger equipamentos eletrônicos contra variações de energia. Ideal para computadores e periféricos, garante maior segurança, estabilidade e vida útil dos aparelhos.",
						260.00m,
						13,
						"https://github.com/user-attachments/assets/edd18644-75db-4596-8b29-7c72f11c9e62"
					},
					{
						"No-break",
						"No-break com bateria interna que garante fornecimento contínuo de energia em caso de queda elétrica. Ideal para proteger computadores e equipamentos sensíveis, evitando perda de dados e danos ao hardware.",
						1100.00m,
						7,
						"https://github.com/user-attachments/assets/d41644ce-149b-4058-987c-8faa6ff128ce"
					}
				}
			);

		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{

		}
	}
}
