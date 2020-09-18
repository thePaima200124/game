#!/usr/bin/env bash

declare -A build_path_options
declare -A build_targets

build_path_option[linux-il2cpp]='-buildLinux64Player "$PWD/game"'
build_path_option[windows]='buildWindows64Player "$PWD/game.exe"'

build_targets[linux-il2cpp]='Linux64'
build_targets[windows]='Win64'

export build_path_option="${build_path_option[$1]}"
export build_target="${build_targets[$1]}"
