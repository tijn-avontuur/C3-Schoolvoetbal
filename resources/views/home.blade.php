<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Toto - Home</title>
    <link href="{{ asset('css/app.css') }}" rel="stylesheet">
    @vite(['resources/css/app.css'])
</head>
<body class="bg-gray-100">
    <!-- Navigatiebalk -->
    <header class="bg-blue-600 text-white py-4">
        <div class="container mx-auto flex justify-between items-center">
            <h1 class="text-2xl font-bold">Toto</h1>
            <nav>
                <a href="/matches" class="px-4">Wedstrijden</a>
                <a href="/login" class="px-4">Inloggen</a>
            </nav>
        </div>
    </header>

    <!-- Foto -->
    <div class="container mx-auto mt-6">
        <img src="{{ asset('img/Schermafbeelding 2024-11-27 104957.png') }}" alt="Voetbal Banner" class="w-full h-64 object-cover rounded-lg shadow-md">
    </div>

    <!-- Wedstrijden -->
    <main class="container mx-auto py-8">
        <h2 class="text-3xl font-bold text-gray-800 mb-6">Huidige Wedstrijden</h2>

        <div class="grid grid-cols-1 md:grid-cols-2 gap-4">
            <!-- Wedstrijd 1 -->
            <div class="bg-white shadow-lg rounded-lg p-4 flex justify-between items-center">
                <div>
                    <h3 class="text-xl font-bold text-gray-700">Ajax vs Feyenoord</h3>
                    <p class="text-gray-600">Stand: 2 - 1</p>
                </div>
                <button class="px-4 py-2 bg-blue-600 text-white rounded hover:bg-blue-700">Inzetten</button>
            </div>

            <!-- Wedstrijd 2 -->
            <div class="bg-white shadow-lg rounded-lg p-4 flex justify-between items-center">
                <div>
                    <h3 class="text-xl font-bold text-gray-700">PSV vs AZ Alkmaar</h3>
                    <p class="text-gray-600">Stand: 1 - 1</p>
                </div>
                <button class="px-4 py-2 bg-blue-600 text-white rounded hover:bg-blue-700">Inzetten</button>
            </div>

            <!-- Wedstrijd 3 -->
            <div class="bg-white shadow-lg rounded-lg p-4 flex justify-between items-center">
                <div>
                    <h3 class="text-xl font-bold text-gray-700">Vitesse vs Utrecht</h3>
                    <p class="text-gray-600">Stand: 0 - 3</p>
                </div>
                <button class="px-4 py-2 bg-blue-600 text-white rounded hover:bg-blue-700">Inzetten</button>
            </div>

            <!-- Wedstrijd 4 -->
            <div class="bg-white shadow-lg rounded-lg p-4 flex justify-between items-center">
                <div>
                    <h3 class="text-xl font-bold text-gray-700">Heerenveen vs Groningen</h3>
                    <p class="text-gray-600">Stand: 2 - 2</p>
                </div>
                <button class="px-4 py-2 bg-blue-600 text-white rounded hover:bg-blue-700">Inzetten</button>
            </div>
        </div>
    </main>

    <!-- Footer -->
    <footer class="bg-gray-800 text-white py-4">
        <div class="container mx-auto text-center">
            <p>&copy; {{ date('Y') }} Toto. Alle rechten voorbehouden.</p>
        </div>
    </footer>
</body>
</html>
