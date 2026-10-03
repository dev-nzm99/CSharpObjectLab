# 🤝 Contributing to the C# OOP Handbook

Thank you for helping improve this project! This repository is a **structured learning path for Object-Oriented Programming in C#**. Contributions that make it clearer, more accurate and more useful for learners are very welcome.

> Please read this guide before opening an issue or pull request. It keeps every chapter consistent and the repository easy to maintain.

---

## 📑 Table of Contents

- [Ways to Contribute](#-ways-to-contribute)
- [Project Scope](#-project-scope)
- [Getting Started](#-getting-started)
- [Repository Conventions](#-repository-conventions)
- [Chapter Template](#-chapter-template)
- [Writing Guidelines](#-writing-guidelines)
- [Code Guidelines](#-code-guidelines)
- [Diagrams](#-diagrams)
- [Exercises and Solutions](#-exercises-and-solutions)
- [Adding a New Chapter](#-adding-a-new-chapter)
- [Commit Messages](#-commit-messages)
- [Pull Request Process](#-pull-request-process)
- [Reporting Issues](#-reporting-issues)
- [Code of Conduct](#-code-of-conduct)
- [License](#-license)

---

## 💡 Ways to Contribute

| Type | Examples |
|---|---|
| 🐛 **Fix errors** | Typos, broken links, wrong output, technically inaccurate statements |
| 📖 **Improve explanations** | Clearer wording, better analogies, missing edge cases |
| 💻 **Improve examples** | More realistic, smaller, or fully runnable code |
| 📊 **Add diagrams** | Mermaid diagrams or exported SVG/PNG images |
| 📝 **Add exercises** | New practice problems with reference solutions |
| 🎯 **Add interview questions** | Accurate, concise answers |
| 🆕 **Propose new chapters** | Open an issue first (see [Adding a New Chapter](#-adding-a-new-chapter)) |

Small fixes (typos, links, formatting) can go straight to a pull request. For anything larger, **open an issue first** so we can agree on the approach.

---

## 🎯 Project Scope

This repository is **only about Object-Oriented Programming in C#**.

✅ **In scope**

- Classes, objects, members, constructors
- Encapsulation, inheritance, polymorphism, abstraction, interfaces
- Access modifiers, static/sealed members, `this`/`base`
- The .NET object model (`System.Object`, boxing, casting, records, garbage collection as it relates to object lifetime)
- Object-oriented design and SOLID principles

❌ **Out of scope** (unless a *small* reference is needed to explain an OOP concept)

- Loops, conditions, collections, LINQ
- `async`/`await`, file handling, exception handling
- ASP.NET, Entity Framework, database programming

If your content is not about OOP, it probably belongs in a different repository.

---

## 🚀 Getting Started

1. **Fork** the repository.
2. **Clone** your fork:

   ```bash
   git clone https://github.com/<your-username>/csharp-oop-handbook.git
   cd csharp-oop-handbook
   ```

3. **Create a branch** from `main`:

   ```bash
   git checkout -b docs/08-encapsulation-fix-typo
   ```

   Suggested branch names:

   | Prefix | Use for | Example |
   |---|---|---|
   | `docs/` | Content changes | `docs/10-polymorphism-improve-examples` |
   | `fix/` | Errors and broken links | `fix/readme-broken-link` |
   | `feat/` | New chapters, exercises, diagrams | `feat/exercises-12-interfaces` |

4. **Make your changes**, then follow the [Pull Request Process](#-pull-request-process).

**Requirements for running examples:** the [.NET SDK](https://dotnet.microsoft.com/download) (the repository targets **.NET 8 or later**) and any editor (VS Code, Visual Studio, Rider).

---

## 🗂️ Repository Conventions

### Folder structure

```text
csharp-oop-handbook/
├── README.md                 # navigation hub only
├── CONTRIBUTING.md
├── LICENSE
├── 01-oop-introduction/
│   └── README.md             # chapter content
├── ...
├── 24-solid-principles/
│   └── README.md
├── diagrams/                 # shared diagram sources and exported images
├── examples/                 # runnable .NET projects, one folder per chapter
├── exercises/                # practice problems, mirrors chapter names
└── solutions/                # reference solutions, mirrors exercises/
```

### Naming rules

- **lowercase kebab-case** with a **two-digit number prefix**: `08-encapsulation`.
- Chapter content lives in **`README.md`** inside the chapter folder.
- `examples/`, `exercises/` and `solutions/` use the **same `NN-topic` folder names** as the chapters.
- Diagram files: `diagrams/NN-topic/descriptive-name.svg` (or `.png`).

### Numbering is stable

**Never renumber existing chapters.** Links, progress trackers and external references depend on them. New chapters take the **next free number**.

### Links

- Always use **relative links**: `[Open →](./08-encapsulation/README.md)` or `../08-encapsulation/README.md` from inside a chapter.
- Do **not** hard-code `https://github.com/...` URLs to files in this repository.
- Check every link you add or change.

### The root README

The root `README.md` is a **navigation hub**, not a textbook. Do **not** add lessons, long explanations, code samples, interview answers or exercises to it. Those belong in chapter folders.

---

## 📐 Chapter Template

Every chapter `README.md` must follow the standard template. Keep the **section order**; remove a section only when it truly does not apply (and say so rather than leaving it empty).

```markdown
# NN. Topic Name

> One-sentence summary of the chapter.

**Level:** 🟢 Beginner | 🟡 Core OOP | 🟠 Intermediate | 🔵 Advanced | 🔴 Design Principles
**Prerequisites:** links to earlier chapters, or "None"

---

## 📑 In This Chapter
## 🎯 Learning Objectives
## 📖 Concept
## 🤔 Why It Matters
## 🧩 Syntax
## 💻 Basic Example
## 🌍 Real-World Example
## 🧠 How It Works
## 📊 Diagram
## ⚔️ Important Comparisons
## ⚠️ Common Mistakes
## ✅ Best Practices
## 🎯 Interview Questions
## 📝 Practice Problems
## 🔑 Key Takeaways

---

[⬅ Previous: Previous Topic](../previous-folder/README.md)
&nbsp;&nbsp;•&nbsp;&nbsp;
[🏠 Main README](../README.md)
&nbsp;&nbsp;•&nbsp;&nbsp;
[Next: Next Topic ➡](../next-folder/README.md)
```

### Navigation footer

Every chapter ends with the **Previous • Home • Next** footer in the exact format above.

- **Chapter 01** has no *Previous* link.
- The **last chapter** has no *Next* link.
- Links must follow the numeric order.

### Level labels

| Level | Chapters |
|---|:---:|
| 🟢 Beginner | `01–07` |
| 🟡 Core OOP | `08–12` |
| 🟠 Intermediate | `13–18` |
| 🔵 Advanced | `19–23` |
| 🔴 Design Principles | `24` |

---

## ✍️ Writing Guidelines

- **Be technically accurate.** Use correct, modern C# terminology. Prefer precision over simplification when they conflict.
- **Avoid common oversimplifications**, for example "value types live on the stack and reference types on the heap". Explain **semantics** (copy vs reference) instead.
- **Teach in order.** A chapter may rely on earlier chapters, never on later ones (link forward only as a "see also").
- **Be concise.** Short paragraphs, tables for comparisons, lists for rules.
- **Explain why**, not only what.
- **Use plain, inclusive language.** Assume the reader is a motivated beginner.
- **Do not copy.** Do not paste text, code or diagrams from books, paid courses or other repositories unless the license clearly allows it. Write your own explanations and examples.
- **Cite sources** (for example official Microsoft documentation) when a claim is subtle or version-specific, and mention the C# version for newer features (for example "C# 12").
- Use emoji **sparingly and consistently**, following the existing section headings.

---

## 💻 Code Guidelines

### Examples must be correct

- Every example must **compile and run** on the supported .NET version.
- Every example that prints something must show an accurate **`Output`** block.
- Keep examples **small and focused** on the concept being taught.
- Prefer **realistic domains** (`BankAccount`, `Order`, `Employee`) over `Foo`/`Bar`.
- Show the **wrong way and the right way** when teaching a pitfall (mark with ❌ / ✅ comments).
- Do not use unrelated C# features that distract from the topic.

### Style

Follow the [.NET coding conventions](https://learn.microsoft.com/dotnet/csharp/fundamentals/coding-style/coding-conventions):

| Element | Convention | Example |
|---|---|---|
| Classes, methods, properties | `PascalCase` | `CalculateTotal`, `OrderLine` |
| Private fields | `_camelCase` | `_balance` |
| Parameters, locals | `camelCase` | `openingBalance` |
| Constants | `PascalCase` | `MaxRetries` |
| Interfaces | `I` prefix | `IPaymentMethod` |
| Indentation | 4 spaces | |
| Braces | Allman style (new line) | |

Other rules:

- Use `var` only when the type is obvious from the right-hand side.
- Use **file-scoped namespaces** and top-level statements in short demo snippets.
- Put code in fenced blocks tagged with the language: ` ```csharp `.
- Keep lines reasonably short so snippets do not scroll sideways on GitHub.

### Runnable projects in `examples/`

```text
examples/
└── 08-encapsulation/
    ├── Encapsulation.csproj
    └── Program.cs
```

Verify before submitting:

```bash
cd examples/08-encapsulation
dotnet build
dotnet run
```

---

## 📊 Diagrams

- **Prefer [Mermaid](https://mermaid.js.org/)** blocks inside the chapter (GitHub renders them automatically):

  ````markdown
  ```mermaid
  classDiagram
      Animal <|-- Dog
  ```
  ````

- Use **SVG** (preferred) or PNG files in `diagrams/NN-topic/` for larger or custom diagrams, and reference them with a relative path:

  ```markdown
  ![Four Pillars of OOP](../diagrams/01-oop-introduction/four-pillars.svg)
  ```

- Keep diagrams **simple and readable** in both light and dark themes.
- Add a short description or caption where the meaning is not obvious.
- Include the source file (`.mmd`, `.drawio`, etc.) alongside exported images when possible.

---

## 📝 Exercises and Solutions

- Put starter files in `exercises/NN-topic/` and reference solutions in `solutions/NN-topic/`.
- Each practice problem in a chapter's table needs:
  - a clear problem statement,
  - a difficulty rating (🟢 easy, 🟡 medium, 🟠 hard),
  - a working reference solution.
- Solutions should be **correct, idiomatic and commented** where the reasoning is not obvious.
- Exercises should be solvable **using only concepts taught up to that chapter**.
- Do not put solutions in the chapter README.

---

## 🆕 Adding a New Chapter

1. **Open an issue** describing the topic, why it fits an OOP-only handbook, and a proposed outline.
2. Once agreed, use the **next free number** (for example `25-composition/`). Do not renumber existing chapters.
3. Create `NN-topic-name/README.md` from the [chapter template](#-chapter-template).
4. Update the **previous chapter's** *Next* link and the **new chapter's** *Previous* link.
5. Update the **root `README.md`**:
   - add the chapter to the correct **module table** (or propose a new module),
   - add a row to the **progress tracker**,
   - update the **level system** and **repository tree** if needed,
   - keep the root README short and navigation-focused.
6. Add `examples/`, `exercises/` and `solutions/` folders for the chapter.

Ideas that are welcome as future chapters: composition, association/aggregation, object equality, immutability, generic OOP design, design patterns.

---

## 🧾 Commit Messages

This project uses the **Conventional Commits** style:

```text
<type>(<scope>): <short summary>
```

| Type | Use for |
|---|---|
| `docs` | Chapter content and documentation |
| `feat` | New chapters, exercises, examples, diagrams |
| `fix` | Corrections to errors, output, or links |
| `style` | Formatting only (no content change) |
| `refactor` | Restructuring without changing meaning |
| `chore` | Maintenance (config, tooling) |

**Scope** is the chapter topic (`encapsulation`, `methods`, `solid`) or `readme`.

Rules:

- Use the **present tense** and **imperative mood** (`add`, `fix`, `update`).
- Keep the subject line **under about 72 characters**.
- Add a body when the *why* is not obvious.

**Examples**

```text
docs(methods): add chapter 06 on methods
fix(inheritance): correct hiding example output
feat(exercises): add practice problems for chapter 12
docs(readme): add chapter 25 to progress tracker
```

---

## 🔄 Pull Request Process

1. Make sure your branch is **up to date** with `main`.
2. Run through the **checklist** below.
3. Open a pull request with a **clear title** (same format as a commit message) and a short description of:
   - **what** changed,
   - **why** it changed,
   - the related **issue** (for example `Closes #12`).
4. Respond to review comments. Maintainers may request changes to keep content accurate and consistent.
5. Once approved, a maintainer merges the PR. Keep PRs **focused**: one chapter or one topic per PR is ideal.

### ✅ Contributor checklist

**All changes**

- [ ] The change is within the **OOP-only scope**
- [ ] Content is **technically accurate** and uses correct C# terminology
- [ ] Spelling and grammar are checked
- [ ] All **relative links** work
- [ ] No copied or copyrighted material

**Chapter changes**

- [ ] The chapter follows the **standard template** and section order
- [ ] The **Previous • Home • Next** footer is correct
- [ ] **Level** and **Prerequisites** are filled in
- [ ] Code examples **compile and run**, and **Output** blocks are accurate
- [ ] Interview questions have concise, correct answers
- [ ] Practice problems link to solutions that exist

**New chapters**

- [ ] The issue was discussed and approved first
- [ ] The root README **table, progress tracker, level system and tree** are updated
- [ ] `examples/`, `exercises/` and `solutions/` folders were added

---

## 🐞 Reporting Issues

Open a GitHub issue and include:

| Issue type | Please include |
|---|---|
| **Error in content** | Chapter and section, what is wrong, what you think is correct, a reference if possible |
| **Broken link** | The file and the link text/URL |
| **Code does not compile or output is wrong** | .NET SDK version (`dotnet --version`), the snippet, the actual error or output |
| **Suggestion** | What you would like to see and why it helps learners |

Search existing issues first to avoid duplicates.

---

## 🧭 Code of Conduct

We want this to be a friendly, respectful space for learners and contributors of every level.

- Be **kind and constructive**. Critique ideas, not people.
- Be **patient** with beginners and with different English proficiency levels.
- **No harassment, discrimination or personal attacks.**
- Assume **good intent**, and ask for clarification before concluding otherwise.

Maintainers may edit, reject or remove contributions and comments that do not follow these principles.

---

## 📄 License

By contributing, you agree that your contributions will be licensed under the repository's [MIT License](./LICENSE).

---

[🏠 Back to the Handbook](./README.md)