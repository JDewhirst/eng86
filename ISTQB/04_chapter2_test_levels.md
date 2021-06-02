# Test Levels

Each level of testing has objectives and characteristics specific to it.

Test levels provide an indication of the focus of the testing and the types of problems it s likely to uncover. They're characterised by attributes: objectives, test basis, test object, typical defects and failures, specific approaches and responsibilities.

1. Unit: Test individual units or pieces of code for a system. Activity: Test Driven Development
2. Integration: Tests performed to ensure that two modules operate together correctly. Activites: Incremental, top down (using stubs), bottom up (using drivers), hybrid. Big Bang testing.
3. System: Tests systems end-to-end. Requires controlled environment. Activity: Functional & non-functional tests.
4. Acceptance: Test performed to determine whether the product indeed satisfies its specifications and user story requirements. Activity: Alpha Testing (pre-release of product tested by end user on developer site), Beta testing (pre-release of product tested by end user on user site)

## Unit Testing

Aka Component/Program/Module testing. Usually carried out by the developer and defects fixed upon being found. Each unit of code is usually created in isolation (for integration at a later stage). Each of those units of code will relate to a certain function or area and be tested by the developer to make sure it works. As more code is developed, more and more tests are created.

### Objectives

* Reduce risk
* Verify whether behaviours of the component meet specification
* Build confidence in the component's quality
* Finding defects in the code.
* Preventing defects from escaping to higher test levels.

### Typical test objects

Components, units or modules. Code and data structures, classes, database modules. 

### Work products used as test basis

Code, detailed design, data model, component specifications

## Integration Testing

Units are integrated and tested together. The focus is on the *integration* itself, not the functionality of the individual modules. There are 2 types of integration tests to remember: Big Bang Integration, Incremental integration (top down, bottom up).

### Top Down

High level modules are created first, so a stub code is needed. A stub is just a stand-in for low level code which is not implemented yet. It just makes sure that other code that depends on it still functions.

#### Adv

Useful in creating software intended to be generic, allows early demonstrations, help identify requirement changes and issues.

#### Disadv

Stubs can create a lot of work, stub definition can be difficult, reproducing test conditions may not be possible.

### Bottom Up

Low level modules are created first. In the absence of parent modules, drivers are used. Driver code imitates the functionality of higher level modules.

#### Adv

Higher accuracy at the granular level. Components are added in a controlled manner. Test conditions easier to create.

#### Disadv

### Objectives

* Reduce risk
* Verifying whether the functional and non-functional behaviours something something look at the slide

### Typical Test Objects

* Subsystems
* Databases
* Infrastructure
* Interfaces
* APIs
* Microservices

### Work Products Used As Test Basis

* Software and system design
* Sequence diagrams
* Interface and communication protocol specifications
* Use cases
* Architecture at component or system level
* Workflows

### Typical Defects & Failures

* Inconsistent message structures between systems.
* Incorrect data, missing data, or incorrect data encoding.
* Interface mismatch
* Failures in communication between systems
* Unhandled or improperly handled communication failures between systems.

## System Testing

Involves a wide range of different tests; GUI, Usability, Exception Handling, Volume, Scalability, Ad-hoc, Installation, Recovery, Performance, Load, Security, Stress.

The size of the company, the time available, what resources are available, budget, learning curve (how long will it take the tester to learn the software); are all things that will impact what amount/kind of system testing will be done.

### Objectives

* Reducing risk
* Verifying whether func and non func behaviours are as designed/specified

### Typical test objects

* Applications
* Hardware/software systems
* Operating systems
* System under test (SUT)
* System configuration and configuration data.

### Work products used as test basis

* System and software requirement specifications (Functional and non-functional)
* Risk analysis reports
* Use cases
* Epics and User Stories
* Models of system behaviour
* State diagrams
* System and user manuals

### Typical Defects and Failures

* Incorrect calculations
* Incorrect or unexpected system function or non-functional behaviour
* Incorrect control and/or data flows within the system
* Failure to properly and completely carry out end-to-end functional tasks
* Failure of the system to work properly in the production environment(s)
* Failure of the system to work as described in the system and user manuals.

## Acceptance Testing

Does the system meet all of the requirements ? This is a question that should have been asked frequently throughout the cycle. Typically verifies the functional fitness of the system for business users. Note: Acceptance Testing can take place before System Testing starts.

**Operation Acceptance Testing**: Aka op readiness testing. Checking that the processes and procedures are in place to allow the system to be used and maintained. It's a crucial element for making sure the product will be functional in its environment. Additional aspects to think about are; can if be backed up ? are there procedures for disaster recovery ? is the end user trained ? what are the maintenance and security procedures ?

**Contract and Regulation Acceptance Testing**

* Contractual: Acceptance criteria outlined in a contract
* Regulations: Some industries have rigid regulations that must be abided by, governmental, legal, etc.

**Alpha/Beta Testing**

Alpha testing performed on the developing site but not by the developing team. Beta testing is performed by customers at their own location. Allows for feedback from potential or existing customers.

# Test Types

Functional - specification based, black box (done at all levels)

Non-functional - Performance, Usability (often used to check the readiness of the system)

Structural - Control Flow, Menu Structure, White-Box (Can be done at all levels)

Change related - Carried out on a live system

## Functional Testing

Looks at the specific functionality of a system. Also called specification-based testing and Blackbox testing. Verifying a specific action or function of the underlying code works. 

## Non-functional Testing

Testing of the quality characteristics of the  component or system. (note: can make use of Blackbox techniques) Can be performed at all test levels.

## Structural

How the code make the functionality work, also called whitebox testing. Can be done at all test levels.

## Change Related Testing

**Retesting (Confirmation)**: After a defect has been fixed, the software should be retested to confirm the original defect has been removed

**Regression Testing**: Carried out on every other part of the system to check that a fixed defect hasn't changed other parts of the system. Repeated testing already tested program. Performed when software or environment is changed. Based on risk. Performed at all levels

**Change Related Maintenance Testing**: Testing in a live environment when there has been: Modification, migration, Retirement of software, Planned upgrade to COTS-based system, hotfixes.

Impact analysis (Risk) and Metrics from previous projects are very important in this area. Impact analysis helps estimate the amount of re-testing and regression testing that needs to be done. What are the possible consequences ? What areas will remain unchanged ?

