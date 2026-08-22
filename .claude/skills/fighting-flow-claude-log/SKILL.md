---
name: fighting-flow-claude-log
description: Maintain the repository-root claude-changes.md change log for Fighting Flow work done with Claude Code. Use before executing any non-trivial code change in FightingFlowDotNetSol, and again once that change is done.
---

# Fighting Flow Claude Log

## Instructions

1. Before executing a non-trivial change (new feature, bug fix, refactor, dependency change — not a one-line typo fix or answering a question), add an entry to the repository-root `claude-changes.md` describing the plan: what will change and why, and the files expected to be touched. Status: `Planned`.
2. Execute the change.
3. Update that same entry afterward:
   - Status → `Done` (or `Abandoned` if it wasn't completed, with a one-line reason), or `In progress` if it spans multiple turns/sessions.
   - Fill in **Outcome**: what actually changed, relevant build/verification results, and anything that deviated from the plan.
4. Keep entries newest-first, one entry per logical change (not per tool call). Don't duplicate what git history already shows — focus on intent and outcome, not a diff.

## Scope

This skill maintains `claude-changes.md` only. It does not authorize commits, pushes, or branch operations, and it's separate from `codex.md` (the Cursor-session handoff doc covered by `.cursor/skills/fighting-flow-checkpoint`) — don't merge the two files.
