
# Dependency Pack
Shared dependency pack for modding Cities Skylines 2, includes:
- Harmony 2.2.2

## Why do we need a Dependency Pack?

## 1. **Technical Stability and Compatibility**
 ### Shipping dependencies separately reduces the risk of DLL version conflicts, which can cause mods to break when different versions of the same dependency are loaded.
- This is a fundamental principle of software development, where isolated dependencies help ensure that all mods rely on a consistent, shared version of a library, reducing the chance of incompatibilities.

## 2. **Ease of Updates and Maintenance**
### Updating a single, shared dependency is more efficient and less error-prone than managing updates across multiple mods.
- When a dependency like Harmony needs to be updated, doing so in one central location prevents the need for every mod author to release an update. This streamlined approach benefits both mod creators and users by simplifying maintenance and ensuring timely adoption of bug fixes and improvements.

## 3. **User Experience and Simplification**
###  A centralized dependency pack simplifies the installation process for users, improving their overall experience.
- Users new to modding or those unfamiliar with the intricacies of dependency management can easily be overwhelmed. A single, well-documented dependency pack reduces confusion and potential errors during mod installation, enhancing accessibility for a wider audience.

## 4. **Transparency**
###  No hidden dependencies buried in mod folders. 
- By ensuring mods themselves do not contain dependencies it provides transparency for users; you can be aware of every runtime a mod loads via the modding platform and UI interfaces. 

## 5. **Community Standards and Practices**
### Establishing a community standard for dependency management promotes collaboration and reduces fragmentation.
- By agreeing on a standardized approach, both mod creators and users benefit from a more cohesive ecosystem. This unity can foster innovation and support, as resources can be pooled for common goals such as tutorial creation, troubleshooting, and enhancements.

## 6. **Future-Proofing and Scalability**
### The separate dependency approach is more scalable and future-proof, accommodating the growth of the modding community and the evolution of the game.
- As the game and its modding community evolve, the likelihood of introducing more dependencies increases. A scalable approach to dependency management ensures the modding ecosystem can adapt without requiring significant overhauls.

## Beware of misinformation and false guidance:

### *'DependencyPack' is broken. It is known to either break the game or just does not work.*
This claim is incorrect. 'DependencyPack' is a lightweight container that simply acts as a bootstrapper for common mod dependencies. It uses thoroughly tested, well-established existing libraries that we test to ensure is compatible with the game. If there are specific instances of malfunction, we encourage users to report these so that they can be addressed promptly.

### *You should remove 'DependencyPack' from your playset.*
The recommendation to remove 'DependencyPack' disregards its crucial role in ensuring mod compatibility and stability. Before removing it, users should be aware that this might affect the functionality of other mods that rely on the shared dependency provided by 'DependencyPack'.

### *Harmony in C:S II is not required as a dependency, mods that need to use Harmony's capabilities can just use it on their own.*
While mods can include their own version of Harmony, this approach is prone to causing conflicts, especially when different mods include different versions of Harmony. 'DependencyPack' ensures that all mods use the same version, which is vital for preventing conflicts and ensuring a stable modding environment.

### *Using this mod is redundant and should not be advised.*
The use of 'DependencyPack' is far from redundant; it is a best practice in software dependency management. It avoids the well-documented issue of "DLL Hell," where multiple versions of the same DLL lead to version conflicts and instability.

### *The game already comes with Harmony so you don't need to download it.*
This claim is also incorrect. Cities Skylines 2 contains part of the Harmony dependencies forked (In the form of 'Colossal.Mono.Cecil') but it does not in fact contain Harmony itself.

### Further notes
- 'DependencyPack' aligns with industry-standard practices for dependency management, promoting a healthier modding ecosystem.
- Centralizing the Harmony dependency ensures that mod authors and users are always on the same, stable version, simplifying development and troubleshooting.
- Encouraging all mod authors to adopt 'DependencyPack' could prevent the very issues this potential flagging claims to address.
- We are committed to maintaining the highest standards of stability and user experience and will continue to review and update 'DependencyPack' to reflect the best practices in the field.

## Understanding the Risks of Independent DLL Distribution in Mods

### The Challenge of Version-Specific Loading

The practice of bundling individual versions of dependencies with each mod operates under the assumption that each mod operates independently. However, this assumption is problematic in the complex environment of game modding, where multiple mods must coexist. This complexity is exemplified when a mod with a newer version of a dependency, such as LibHarmony 2.3.3, loads before others that require an older version, like 2.2.2. This results in an error where the game's mod loader fails to find the expected version:

```
[ERROR] Failed to resolve assembly: '0Harmony, Version=2.2.2.0, Culture=neutral, PublicKeyToken=null'
AssemblyResolutionException: Failed to resolve assembly: '0Harmony, Version=2.2.2.0, Culture=neutral, PublicKeyToken=null'
```

#### Dissecting the Error
- **Assembly Mismatch**: The conflict occurs because the newer version overrides the older, expected version in the game's environment.
- **Consequences**: Mods that depend on the older version's functionality may fail to load or work incorrectly, leading to instability and crashes.

#### Broader Implications
- **Developer Strain**: Mod authors are forced to deal with compatibility issues and user complaints unrelated to their mod's code.
- **Player Dilemma**: The gaming community faces a steep learning curve and potential disenchantment with modding due to these avoidable technical hurdles.

### Mitigation Through Shared Dependency Packs

While a shared dependency pack may not resolve all possible conflicts, especially with future updates or changes to the dependencies, it significantly mitigates current risks:

#### Centralized Version Control
- By providing a single, shared version of LibHarmony (such as with 'DependencyPack'), all mods reference a uniform version, substantially decreasing the likelihood of version conflicts.
  
#### Proactive Conflict Prevention
- A shared dependency pack can anticipate and prevent conflicts, ensuring all mod authors and users are working from the same baseline.
  
#### Community-Wide Stability
- Reduces the complexity of the modding landscape, making it more accessible and enjoyable for all participants.

#### Easing Future Transitions
- Establishes a framework for dealing with updates: should a new version of a dependency be required, it can be rolled out in a controlled and coordinated manner, minimizing disruption.

### Conclusion and Future Outlook

The 'DependencyPack' shared dependency pack represents a strategic approach to maintaining mod compatibility within Cities Skylines 2. While it's true that software dependencies will continue to evolve, and new versions will be released, the shared pack structure sets the stage for a manageable update process. It supports the longevity and robustness of the modding ecosystem, ensuring that mods can continue to thrive without falling prey to the cascading failures that version conflicts can cause.

(Harmony repo https://github.com/pardeike/Harmony)