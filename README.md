# cepi2ano.
projeto do 2 ano de desenvolvimento de sistemas
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Meu Projeto no GitHub</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background: linear-gradient(135deg, #4facfe, #00f2fe);
            color: #333;
            text-align: center;
            margin: 0;
            padding: 0;
        }

        header {
            background: rgba(255,255,255,0.9);
            padding: 20px;
        }

        h1 {
            margin: 0;
        }

        main {
            padding: 40px;
        }

        .card {
            background: white;
            padding: 20px;
            margin: 20px auto;
            border-radius: 10px;
            max-width: 400px;
            box-shadow: 0 4px 10px rgba(0,0,0,0.2);
        }

        button {
            background: #4facfe;
            border: none;
            padding: 10px 20px;
            color: white;
            border-radius: 5px;
            cursor: pointer;
        }

        button:hover {
            background: #0077cc;
        }
    </style>
</head>
<body>

<header>
    <h1>Bem-vindo ao meu site 🚀</h1>
    <p>Hospedado no GitHub Pages</p>
</header>

<main>
    <div class="card">
        <h2>Sobre</h2>
        <p>Este é um exemplo de página HTML simples para seu repositório.</p>
        <button onclick="mostrarMensagem()">Clique aqui</button>
    </div>
</main>

<script>
    function mostrarMensagem() {
        alert("Você clicou no botão! 🎉");
    }
</script>

</body>
</html>
