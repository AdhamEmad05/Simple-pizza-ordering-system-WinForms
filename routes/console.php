<?php

use Illuminate\Support\Facades\Artisan;

Artisan::command('inspire', function () {
    $this->comment('Build something great with Laravel!');
})->purpose('Display an inspiring message');
