# GitHub Copilot Instructions for RimWorld Mod: CIWS_Miscellaneous (Continued)

## Mod Overview and Purpose

**CIWS_Miscellaneous (Continued)** is an update and continuation of the popular **CIWS** mod, adding a variety of enhancements to the RimWorld game. This mod introduces new features, balances existing systems, and introduces a new set of items and equipment to improve player experience.

## Key Features and Systems

- **Shield Belts**: Adds four levels of shield belts (excellent, sophisticated, epic, legendary) that can block both melee and ranged weapons. The first two grades can be manufactured on the machine table.
- **Snow White's Coat**: A unique piece of apparel that covers all body parts.
- **Transport Cabin Enhancements**: Increases the carrying capacity of heavy transport cabins to 600 and enhances the high-power drainage pump, speeding up drainage.
- **Automatic Electric Stoves**: Allows batch cooking of food, processing insect meat, practicing cooking skills, and synthesizing vegetable protein.
- **Nano-Repair Chamber**: Quickly restores wounds.
- **Enhanced Heating and Cooling**: Improves the power of heaters and coolers.

## Coding Patterns and Conventions

The mod follows a consistent coding pattern and adheres to the following conventions:

1. **Class Naming**: Use PascalCase for class names (e.g., `CIWS_Gizmo_EnergyShieldStatus`).
2. **Method Naming**: Use PascalCase for method names and camelCase for local variables (e.g., `GetWidth`, `energyGainPerTick`).
3. **XML Def Naming**: Use PascalCase for XML def names (e.g., `Apparel_Belts.xml`).
4. **File Structure**: Organize C# files in a logical structure, with related classes grouped together.
5. **Code Comments**: Provide clear and concise comments within the code to explain complex logic or new features.

## XML Integration

The mod extensively uses XML files to define new items, recipes, and hediffs. Key XML files include:

- **Apparel Definitions**: Define new apparel items like shield belts and Snow White's coat.
- **Recipe Definitions**: Define new recipes for batch cooking and processing insect meat.
- **Hediff Definitions**: Define new hediffs like the super vaccine.

When working with XML files, ensure that:

- **Def Types**: Use the correct `Def` type for each file (e.g., `ThingDef` for items, `RecipeDef` for recipes).
- **Def Names**: Ensure that def names are unique and do not conflict with existing RimWorld or mod definitions.
- **Attributes**: Use the correct attributes and values for each def type.

## Harmony Patching

The mod uses Harmony patching to modify existing RimWorld behavior. Key Harmony patches include:

- **Gizmo Energy Shield Status**: Modifies the energy shield status gizmo to display additional information.
- **Shield Belt Absorption**: Adjusts the shield belt's absorption behavior to block both melee and ranged attacks.
- **Nano-Repair Chamber**: Enhances the repair chamber to restore wounds more quickly.

When working with Harmony patches, ensure that:

- **Patch Methods**: Use the `[HarmonyPatch]` attribute to specify the target method for patching.
- **Prefix/Suffix Methods**: Implement prefix or suffix methods to modify or extend the behavior of the target method.
- **Avoid Conflicts**: Ensure that patches do not conflict with other mods or existing RimWorld behavior.

## Suggestions for Copilot

When using GitHub Copilot for this mod, consider the following suggestions:

- **Focus on XML Integration**: Since XML files define new items and behaviors, focus on generating and editing XML def files.
- **Enhance Harmony Patches**: Use Copilot to generate new Harmony patches or enhance existing ones to modify RimWorld behavior.
- **Optimize C# Code**: Use Copilot to optimize existing C# code, improve performance, and add new features.
- **Document Changes**: Ensure that all code changes are well-documented with comments to explain the purpose and logic of the changes.
- **Test Thoroughly**: After generating or modifying code, thoroughly test the mod in RimWorld to ensure that new features work as intended and do not introduce bugs.

## Support and Reporting

For best support, please use the Discord-channel for error reporting. Do not report errors by making a discussion thread, as you will not receive any notification.

If you have the solution for a problem, please post it to the GitHub repository.

To ensure compatibility and stability, use RimSort to sort your mods.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

