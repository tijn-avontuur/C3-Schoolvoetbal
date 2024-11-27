<?php

namespace Database\Seeders;

use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Hash;

class UsersTableSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        DB::table('users')->insert([
            [
                'name' => 'admin',
                'email' => 'admin@example.com',
                'password' => '$2y$12$fV14f.wSDr4WApsNNle7Yu/pXgrYNZpKrIQv3l7YnT00vV5SCZEx6',
                'isAdmin' => 1,
                'balance' => 500.00,
                'created_at' => now(),
                'updated_at' => now(),
            ],
            [
                'name' => 'user',
                'email' => 'user@example.com',
                'password' => '$2y$12$fV14f.wSDr4WApsNNle7Yu/pXgrYNZpKrIQv3l7YnT00vV5SCZEx6',
                'isAdmin' => 0,
                'balance' => 500.00,
                'created_at' => now(),
                'updated_at' => now(),
            ],
        ]);
    }
}