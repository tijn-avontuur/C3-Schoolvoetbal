<?php

namespace Database\Seeders;

use App\Models\Team;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;

class TeamSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        // Zorg ervoor dat er een gebruiker met id 1 bestaat
        $user = DB::table('users')->where('email', 'testuser1@example.com')->first();

        if ($user) {
            Team::factory(10)->create([
                'user_id' => $user->id,
            ]);
        }
    }
}