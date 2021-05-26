# Test Management

## Organisation

### Test Manager

Project Manager, Development Manager, Quality Assurance Manager, Manager of Test Group.

**Typical tasks for a Test Manager:** Co-ordinate and possibly write and review test strategy (for the project) or policy (for the organisation). Plan and negotiate with proj managers and other stakeholders. Directs the spec, prep, implementation and execution of tests. Time effort and cost. Report - Progress vs Actual. Quality of the work product and the quality of the testing. Ensures appropriate training has taken place. Make sure the appropriate environments are in place.

### Tester

Can be Developers, Business Analysts, Users, SMEs, Specialists.

**Typical tasks:** Review and contribute to the test plans. Review requirements. Test specification and test cases based on the test plan. Prepare test data. Execute test procedures, log and evaluate results and document deviation. Use test administration, management and monitoring tools. Automate tests. Review tests developed by others.

### Independence

Separation of responsibilities which encourages the accomplishment of objective testing. The effectiveness of finding defects by testing and reviews can be improved by using independent testers. It is thought that the software is tested more thoroughly. This is extremely powerful in situations where an independent tester is used to test, rather than the author of a work product.

<u>Levels of Independence</u>

1. No independent testers - developers test their own code
2. Independent testers in the development team
3. Independent test team or group within the org
4. Independent testers from the business or user community
5. Independent test specialists in usability, security, etc
6. Independent testers external to the organisation

## Test Planning

The purpose of a test plan is to; 

* Determine objective, scope, who is doing what.
* Timescale and budget
* Selecting metrics for test monitoring and control

Test planning activities: Scope & Risk, What to test, Who does what, Scheduling, Levels of Detail, Test levels and entry/exit criteria.

### Estimation Techniques

**Metric Based** - Relies on *data* collected from previous or similar projects. Fairly accurate approach when comparing similar sized projects.

**Expert Based** - The estimations are based on *experience*. This could be from Developers, analysts, SMEs, Test Consultants, etc. It can be similar to the Wideband Delphia approach, but not always done in that exact way.

Common metrics - Percentage of work done, number of test cases executed, defect totals and details, subjective confidence of release, milestones achieved.

## Test Monitoring & Control

The purpose of test reporting is to summarize and communicate test activity information, both during and at the end of a test activity. 

By monitoring the progress of the project we are allowing ourselves to take corrective measures to ensure we stay on target. Test control activities include; Re-prioritising tests, change the test schedule, review product risks, adjust the scope

Test progress reports; summary of testing performed, what occured during a test period, deviations from the plan, status of testing and product quality with respect to the exit criteria or definition of done, factors that have blocked or block progress, metrics of defects, test cases, test coverage, activity progress, and resource consumption, residual risks, reusable test work products produced.

## Test Strategy and Approaches

Test strategy defines how testing is done, it will provide a general description of how to use test processes. It can either be preventative (developed early in the lifecycle) or reactive (left until before the start of test execution).

<u>Approaches</u>

* **Analytical** - Rely on analysis of some factors such as risk-based testing, where testing is directed to areas of greatest risk
* **Model Based** - Base test on a model such as statistical information about failure rates. Some model of a business process
* **Methodical** - Rely on systematic use of some predefined test or test conditions such as failure based (including error guessing and fault attacks), checklist based and quality characteristics based.
* **Process Compliant** - Adhere to process developed for use with standards and various Agile or traditional waterfall approaches
* **Reactive** - e.g. exploratory testing. Heuristic based, where testing is more reactive to events than pre-planned, and where execution and evaluation are concurrent tasks.
* **Directed** - AKA Consultative. Such as those where test coverage is driven primarily by the advice and guidance of tech and/or business SMEs outside or within the test team
* **Regression Averse** - Highly automated. Avoids regression of existing capabilities.

<u>Entry & Exit Criteria</u>

Used to determine when a given test activity can start, defines the preconditions for undertaking a test activity. 

**Entry Criteria:** Specific conditions or on-going activities that must be present before a process can begin (e.g. availability of a test environment, testable code available, all test data is available and correct, availability of testable requirements such as user stories or models)

**Exit Criteria:** Used to determine when a given test activity is complete. Should be defined for all of the test activities. Should be included in all relevant test plans. Be agreed as early as possible. (e.g. We have run out of money, when the deadline is hit, planned test have been executed, the number of unresolved defects is within an agreed limit, the evaluated level of quality criteria such as reliability and performance is sufficient, a certain level of coverage has been achieved)

## Configuration Management

**The ISTQB says;** A discipline applying technical and administrative direction and surveillance to identify and document the functional and physical characteristics of a configuration item, control changes to those characteristics, record and report change processing and implementation status, and verify compliance with specified requirements.

If configuration management is not handled correctly then you may find multiple people working on the same element at the same time without any knowledge of the others work. Not able to match program source to object code. The system being difficult to maintain as the documents are not correct. Faults that were fixed reappear. Can't rollback to a previous version.

Configuration also allows for the identification and reproduction off; test items, test documents, tests, test harnesses.

**Configuration Control - ** Maintenance of record of test results.

## Risk Management

ISTQB says

*  **Risk -** A factor that could result in future negative consequences; usually expressed as a impact and likelihood.
* **Risk Analysis - ** The overall process of risk identification and risk assessment.

Consider both the likelihood of occurrence of the risk and the impact of the risk. We need to test the things that probably won't  break but would be very bad if they did.

Early risk analysis is often educated guesses. At key project milestones it's important to ensure that you revisit and follow up on the risk analysis.

### Product Risk

The possibility that the system or  software might fail to satisfy or fulfil some reasonable expectation of the customer, user, or stakeholder. Affects the quality of the product. e.g. potential that the software/hardware could cause harm, poor software characteristics i.e security, reliability, maintainability or performance.

### Project Risk

A risk related to management and control of the (test) project, e.g. lack of staffing, strict deadlines, changing requirements, political issues, supplier contracts, etc.

### Avoiding Risk

Brainstorming, painstakingly reading the requirements and specifications. Workshop or interview with SMEs. 

### Risk Based Testing

An approach to testing to reduce the level of product risks and inform stakeholders of their status. It involves the identification of product risks and the use of risk levels to guide the test process.

## Defect Management

A defect is an imperfection or deficiency in a work product where it does not meet its user requirements or specifications.

Defect management is the process of recognising, investigation, taking action and disposing of defects. It involves logging defects, classifying them, identifying the impact.

### Defect Reports

Can be raised at any time by anyone, they should have the following objectives:

* Provide as much information as possible
* Allow the defect to be tracked and easily reported on, helping to supply metrics
* Help develop test improvements, identify how the functionality should be tested next time.

They should include:

* Test incident report identifier & Date
* Title and summary
* Incident description (expected results, actual results, anomalies, date and time, procedure step, attempts to repeat, testers comments, observers comments)
* Impact
* Urgency to fix
* State of the defect report (open, deferred, duplicate, waiting to be fixed, awaiting confirmation testing, re-opened, closed)
* Conclusions, recommendations and approvals

