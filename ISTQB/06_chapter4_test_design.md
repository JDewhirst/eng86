# Test Design

## Key Terms

- **Test Plan** – A document describing the scope, approach, resources and schedule of  intended test activities 
- **Test Data** – Data created or selected to satisfy the execution preconditions and inputs to  execute one or more test cases (i.e. collection of test cases grouped for test execution  purposes) 
- **Test Condition** – An aspect of the test basis that is relevant in order to achieve specific  test objectives. Roughly defined as the aim/goal of a certain test. 
- **Test Case** – A set of preconditions, inputs, actions (where applicable), expected results and postconditions, developed based on test conditions. 
- **Test basis/base** – The body of knowledge used as the basis for test analysis and design. 
- **Test Suite** – A set of test cases or test procedures to be executed in a specific test cycle. 
- **Test Coverage** – The degree to which specified coverage items have been determined or  have been exercised by a test suite expressed as a percentage (or simply – % of test  cases in test suite carried out). 
- **Test Design Specification** – Specifies the test conditions for a test item, the detailed test  approach and identifies the associated high-level test cases 
- **Test Charter** – Documentation of test activities in session-based exploratory testing. 
- **Test Oracle** – A source to determine an expected result to compare with the actual result  under test. E.g. the existing system (for a benchmark), other software, user manuals or an  individual’s specialised knowledge, but should NOT be the code.

## Test Design Process

![image-20210525102318854](\images\test_design_process.png)

![image-20210525101820102](\images\test_basis.png)

## Test Cases

Once you understand the conditions, you can create the test cases. These consist of:

* Execution preconditions
* Expected results
* Execution post-conditions

Test cases are developed to cover a certain test objective or test condition.

### Ways you may tackle Test Cases

Functional - Test each function

Domain - Test by partitioning different sets of values

Specification based - Test against specifications

Risk based - Imagine a way in which a program could fail and design tests to check whether the program will actually fail

User - How the user will approach the system

Scenario/Use Case - Based on actors/users and a set of actions they are likely to perform in real life

Exploratory - The tester actively controls the design of tests as those tests are performed and uses information gained wile testing to design new and better tests.

### Expected Results

Produced as part of the specification of a test case. If they have not been defined then an incorrect result may be interpreted as the correct one.

**Test Oracle:** A source to determine expected results to compare with the actual result of the software under test. Incl, Other Software, A user manual, An individual's specialised knowledge, the existing system (for a benchmark).

## Test Procedures

Are the steps for executing the test case and the process for determining whether the software passed or failed the test.

## Traceability

The degree to which a relationship can be established between two or more work products.

* Ability to trace test conditions to specs and requirements
* Allows impact analysis when the requirements change
* Ensures requirements test coverage can be determined for a set of tests

![image-20210525104416088](\images\traceability_matrix.png)

## Scheduling

Once procedures are complete the test cases can be formed into a test execution schedule. This defines the order in which the various test procedures are executed. The test exec schedule will take into account risk, prioritisations, other things.

Regression testing must be done last, highest priority run first. Take into account the logical order of execution and technical dependencies.. Test plans must be highly dynamic.

## Test Coverage

Quantitative measures are important to help stakeholders understand how much of the system has been tested. 

Coverage might make up part of the completion criteria defined in the test plan. It can also be used to tell us when to stop testing. 

# Testing Techniques

## Black Box Testing

(aka specification based testing, requirements based testing, business requirements testing, functional testing)

Based entirely on the software requirements and specifications. Techniques we look at; Sanity/Smoke Check, Decision Table Testing, State Transition Testing, Equivalence Partitioning, Boundary Value Analysis, Use Case Testing.

Can be done at all test levels.

### Sanity and Smoke Testing

Acceptable in Integration/System/and Acceptance Testing levels.

**Smoke Test:** Check system health, aim is not to find a defect. Verifies critical functions e.g. does the computer turn on without going up in flames. Does my mouse work ? etc.

**Sanity Test:** Makes sure bugs reported in previous builds are fixed for this release before doing a full regression test. Verifies NEW functionality.

### Decision Table Testing

Systematic approach. Test system behaviour with different combinations of conditions. Lists all the conditions that can occur and their consequences.



![image-20210525112200516](\images\decision_table_testing.png)

Sets of conditions are Boolean values.

![image-20210525113459996](images\decision_table_activity.png)

|       | Condition/Action              | Case 1 | Case 2 | Case 3 | Case 4 | Case 5 | Case 6 |
| ----- | ----------------------------- | ------ | ------ | ------ | ------ | ------ | ------ |
| COND1 | **Time is before 5:30pm**     | Y      |        |        |        | Y      | Y      |
| COND2 | **Recipient address present** | Y      | Y      | Y      |        | Y      |        |
| COND3 | **Subject message present**   | Y      | Y      |        | Y      |        | Y      |
| ACT1  | Send email                    | X      |        |        |        |        |        |
| ACT2  | Put email in pending folder   |        | X      |        |        |        |        |
| ACT3  | Give warning message          |        |        | X      | X      | X      | X      |

### State Transition Testing

When a system is represented as being in one state and transitions from that state to another. The transformations are determined by the rules of the system. This means we can follow these rules to create a diagram that represents change of transitions and thus a test to see if it works. 

<u>Terminology</u>

- **States** – How something exists at that time. (TV  On/Off/Standby) 
- **Transitions** – The change from one state to another (The  arrows on the diagram). Transitions are triggered by... 
- **Inputs or Events** – (e.g. Press Power OFF via Remote  Control) 
- **Actions** – The actions that can result from a transition  (able to watch TV)

### Equivalence Partitioning/ Boundary Value Analysis

Rather than trying to test infinite amounts of inputs, we strategically sample them. Divides a set of test conditions into partitions. Keeps the number of test cases down, Testing Principle "Exhaustive Testing Is Impossible"

### Use Case Testing

Use cases describe actions between actor's and systems. Step by step test cases are derived from use cases for each 'Use Case' (e.g. the tasks 'Track progress' will have a step by step test case.)

It's very useful when testing process flows and business rules. Very effective in defining acceptance tests as the use case usually represents how the system will be used. Often good practice to write a test case representing each use case.

<u>Terminology</u>

* **Actors** - Whoever or whatever expects the service from the system
* **Use Cases** - Shown as an oval and represents a function the system will perform as a response to a trigger from an actor
* **Systems Boundary** - A box around all of the use cases. Helps to agree the scope of the system
* **Associations** - The lines that link actors to use cases.

**Example**

In this diagram each oval is a use case.

![image-20210525135559615](images\use_case_testing_diagram..png)

#### Use Case Descriptions

Don't include gui details in them, it makes things more brittle. It's solutionising.

#### Cons

Tying services to users may make the sytem to rigid. But to be useful a system has to satisfy its users needs.

If you do not have a wide selection of personnel in the Use Case team then a narrow focus can obscure all the services a user requires.

Focus can eb swayed to how the user will use the system rather than something something

Fourth item

#### Success Factors

**Size of team** - A small team made up of the right characters is much more effiient, *but* involve as many stakeholders as possible

**Know when to stop** - Stop developing use cases once they are complete and satisfactorily meet audience needs. Need a definition of done. Establish a boundary between the system and the environment to stop it growing wildly out of control.

**Reviewing use cases** - Do this often.



## Experience Based Techniques

Best used in low stakes scenarios.

### Error Guessing

Error Guessing is a test design technique where the experience of the  tester is used to anticipate what defects might be present in the  component or system under test as a result of errors made, and to  design tests specifically to expose. them.

- **Defect and Failure lists** - can help identify areas that are susceptible  to problems 
- **Fault Attack** – This approach is to list possible errors and design tests  around that list. Directed and focused attempt to evaluate a specific quality characteristic of a test object by attempting to force a specific failure to occur.
  - Benefits include; increased software resilience, allows devs to see the results of bugs before going live, devs can make changes to previously unknown issues.

### Exploratory Testing

An informal and reactive test design technique where the tester actively controls the design of the tests as those tests are performed and uses information gained while testing to design new and better tests. Avoids ‘Pesticide Paradox’.

It's an important tool in the hands of SMEs, it is especially suited to web app development.

* Advantages
  * Does not require much preparation
  * Useful when there is time pressure, lack of resources or inadequate specifications
  * Testers report a large proportion of bugs via this method.
* Disadvantages
  * There is no review of test planning, an experienced user of the system may not be an experience tester.
  * Testers have to remember the exact steps they took to create a defect - otherwise reproduction may be difficult

**Four Key Elements:** Product Exploration, Test Execution, Heuristics, Reviewable Results.

You still need a well defined structure rather than a scatter gun approach. You also need to be able to define how complete your exploratory testing was. This can be attained through Heuristics/Mnemonics.

### Checklist-based testing

Testers design, implement, and execute tests to cover test conditions found in a checklist.

Checklists are created based on (usually) a professional tester's experience of known problem areas. Checklist is drawn up during test analysis as a set of test conditions and may reuse or update previous checklists. 

As part of analysis, testers create a new checklist or expand an existing checklist, but testers may also use an existing checklist without modification. Such checklists can be built based on experience Checklists can be created to support various test types, including functional and non-functional testing. 

In the absence of detailed test cases, checklist-based testing can provide guidelines and a degree of consistency. 

Have to remember the exact steps they took to create a defect – otherwise reproduction may be difficult.

Coverage is defined by completion of the checklist.

## White Box Testing

(aka structural testing, glass box testing, code-based testing.)

Tests internal structures as opposed to Functional Testing.

Only need one test case to cover all of a piece of sequential code and to cover all of a loop, since there are no decisions being made.

### Decision and Statement Coverage

- **Decision (branch) Coverage (DC)** - Check if each possible branch from a decision point has been executed at least once (i.e. total number of test cases required to ensure each one of the possible branches from each decision  point is executed at least once).
- **Decision Condition Testing** – A white box test design technique in which test cases are designed to execute condition outcomes and decision outcomes.
- **Statement Coverage (SC)** – Check if each statement in the code has been executed at least once (i.e. total number of test cases required to execute each node at least once).
- **Statement Testing** – A white box test design technique in which test cases are designed to execute statements.

## How To Choose A Test Technique

What is the type of system ? Is it safety critical ? Is it a financial system ? Is it web or cloud based ?

What are the regulatory standards

Customer/Contractual Requirements

The Level of Risk

