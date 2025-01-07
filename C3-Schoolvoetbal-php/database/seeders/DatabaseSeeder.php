<?php

namespace Database\Seeders;

use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Hash;

class DatabaseSeeder extends Seeder
{
    /**
     * Seed the application's database.
     */
    public function run(): void
    {
        // Voeg een gebruiker toe als er geen bestaat
        $user = DB::table('users')->where('email', 'testuser1@example.com')->first();

        if (!$user) {
            DB::table('users')->insert([
                'id' => 1,
                'name' => 'TestUser1',
                'email' => 'testuser1@example.com',
                'email_verified_at' => null,
                'password' => '$2y$12$aSxxSzaJH1bdQwJgoIHfVeeJfwn6Mlpb4CyM6rgh7kH...',
                'remember_token' => null,
                'role' => 'user',
                'created_at' => now(),
                'updated_at' => now(),
            ]);
        }

        // Roep de andere seeders aan
        $this->call([
            TeamSeeder::class,
            // Voeg hier andere seeders toe als dat nodig is
        ]);
    }
}