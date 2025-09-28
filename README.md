# Quiz

This was my first big project, built in 2023 for my middle school final grade. It is a Windows Forms quiz game inspired by "Who Wants to Be a Millionaire" that presents multiple-choice questions, keeps score, and ends the game when the question set is exhausted or the countdown timer expires.

## Features
- Multiple-choice questions loaded from `Quiz/Json/questions.json`.
- Scoreboard that increments for each correct answer and shows the final score at the end.
- Visual feedback by highlighting the selected answer in red or green.
- Countdown timer (minutes/seconds) that can auto-end the quiz.
- WinForms UI themed with image resources shipped in `Quiz/Resources/`.

## Prerequisites
- Windows with Visual Studio 2019 or later (or the .NET Framework 4.7.2 tooling).
- .NET Framework 4.7.2 development workload installed (`Quiz.csproj` targets v4.7.2).

## Run the project
1. Open `Quiz.sln` in Visual Studio.
2. Restore NuGet packages if prompted (Newtonsoft.Json and supporting libraries are referenced).
3. Set `Quiz` as the startup project and press `F5` to build and run.

You can also build from the command line with MSBuild:

```powershell
msbuild Quiz.sln
```

The compiled executable will be in `Quiz\bin\Debug` (or `Release` depending on the build configuration).

## Customise the question set
- Questions live in `Quiz/Json/questions.json` and are loaded at runtime.
- Each entry defines a `Caption`, a list of `Answers`, and the `CorrectAnswerNumber` (1-based index).
- Update the JSON file, rebuild, and restart the application to include your changes.

## Project structure
- `Quiz/Form1.cs`: UI logic for showing questions, handling answer selection, and the countdown timer.
- `Quiz/Service/QuestionService.cs`: Manages progression, scoring, and determining the correct answer.
- `Quiz/Repository/QuestionRepository.cs`: Reads and caches the question list from JSON.
- `Quiz/Model/`: Simple POCOs (`Question`, `Answer`) used throughout the app.
- `Quiz/Resources/`: Images used to style the UI.
- `packages/`: NuGet dependencies checked into source.

Feel free to adapt the visuals or extend the game logic: shuffle questions, add lifelines, or persist high scores.
