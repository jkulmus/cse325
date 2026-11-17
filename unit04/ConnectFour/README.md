# U04 Assignment: Connect Four with Blazor

**Student:** Jacquelyn Kulmus
**Course:** CSE 325

## Overview

A two-player Connect Four game built with .NET 8 and Blazor,
following the Microsoft Learn Connect Four tutorial.

## Game Features

- Seven-column, six-row game board
- Alternating player turns and animated falling pieces
- Horizontal, vertical, and diagonal win detection
- Tie detection and full-column error messages
- Reset functionality after a game ends
- Board and player colors configured through component parameters

## Additional Feature: Move History

The move history displays each successful move, including its
move number, player, and selected column. It also displays the
total number of moves and provides a scrollable list.

Rejected moves are not added to the history. Resetting the game
clears both the board and the move history.

## Run Locally

Install .NET SDK 8.0.425, as specified in global.json.

From the unit04/ConnectFour directory, run:

    dotnet watch

Open the localhost URL displayed in the terminal.

## Demonstration Video
https://youtu.be/uixJXYp2gBY

## Tutorial Reference

[Microsoft Learn: Build Connect Four with Blazor](https://learn.microsoft.com/en-us/training/modules/dotnet-connect-four/)