<script>
    // Aquí puedes manejar la lógica del formulario si es necesario
    let username = '';
    let password = '';

    function handleSubmit(event) {
        event.preventDefault();
        // Lógica para manejar el inicio de sesión
        console.log('Username:', username);
        console.log('Password:', password);
    }
</script>

<style>
    html, body {
        margin: 0;
    padding: 0;
    width: 100%;
    height: 100%;
    overflow: hidden; /* Desactiva los scrolls */
    font-family: Arial, sans-serif;
    }
    .full-screen {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh; /* 100% de la altura de la ventana */
    background: url('http://mxsrvapps/resources/GT-Trazability-Contro-Panel/Image/10219-cesped.jpg') no-repeat center center fixed;
    background-size: cover; /* Ajusta la imagen para cubrir todo el espacio */
    }

    .frosted-glass-container {
        background: rgba(255, 255, 255, 0.1);
        backdrop-filter: blur(10px);
        -webkit-backdrop-filter: blur(10px);
        border-radius: 10px;
        box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
        padding: 20px;
        width: 300px;
        text-align: center;
    }

    .login-form input[type="text"],
    .login-form input[type="password"] {
        width: 100%;
        padding: 10px;
        margin: 10px 0;
        border: none;
        border-radius: 5px;
        box-sizing: border-box;
    }

    .login-form input[type="submit"] {
        width: 100%;
        padding: 10px;
        background-color: #007BFF;
        color: white;
        border: none;
        border-radius: 5px;
        cursor: pointer;
    }

    .login-form input[type="submit"]:hover {
        background-color: #0056b3;
    }
</style>

<div class="full-screen">
    <div class="frosted-glass-container">
        <form class="login-form" on:submit|preventDefault={handleSubmit}>
            <input type="text" id="username" name="username" placeholder="Ingresa el usuario" bind:value={username}><br>
            <input type="password" id="password" name="password" placeholder="Ingresa la contraseña" bind:value={password}><br>
            <input type="submit" value="Entrar">
        </form>
    </div>
</div>
