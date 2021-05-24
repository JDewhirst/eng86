# Static Testing

Static testing is meetings and reading. Reviews, etc. Not running the code. Reviewing requirements.

Static testing is a key part of early testing. There is a lower chance of defects, reduced time & cost, improved communications. It is also an important part of security testing. 

## Purposes

Typical review objectives include; Finding defects, gaining understanding, generating discussion, education, decision making by consensus.

## Benefits of Reviews

Getting everyone onto the same page, including non-coding/technical members. You can do it early, find defects early, find bad requirements early. 

## What can be inspected ?

Code, requirements, business policy, strategy, test plans/designs/cases, design models, contracts, plans, schedules, and budget. Any piece of documentation.

## Reviews and Levels of Formality

From informal to most formal.

**Informal** - No formal process. Not usually documented. Inexpensive way to achieve limited benefits. May be implemented as Pair Programming. Checklists are optional

**Walkthrough** - Led by Author of Document. Prior preparation by reviewers. Can vary widely in practice from formal to informal. Main purpose to enable learning. Scribe is mandatory. Checklists are optional.

**Technical Review** - Gain consensus. Prior preparation by individuals. Scribe is mandatory (ideally not Author). Checklist are optional. Usually performed as a peer review. Led by facilitator/moderator. Checklists are optional. Can also vary widely from informal to formal. 

**Inspection** - Based on rules, checklist, entry and exit criteria. Prior preparation is essential. Main purpose to find defects but Secondary may be process improvement. Led by trained facilitator/moderator. Metrics are collected and used for improvement of the software development process.

##  Review Attendees

**Review leader** – Responsible for the review, decides who’s going to be invited and where the meeting will take place. 

**Facilitator/Moderator** – mediates reviews, ensures effective running of review. Makes the final decision of whether or not to release an updated document.

**Management** – Plans and decides on the execution of reviews. Determines whether review process objectives have been met. Assign staff and budget. Monitors costs and controls decisions. 

**Scribe** – Collates potential defects found during the individual review activity. Records new potential defects, open points, and decisions from the review meeting (when held) 

**Author** – of the document being reviewed. Helps understanding of the defects 

**Reviewers** – May be SMEs, Stakeholders, etc. Identify potential defects in the work under review. May represent different perspectives (e.g. tester, programmer, BA etc)

## Formal Review

There are five activities in a formal review; Planning, Initiate Review, Individual Review, Issues communication and analysis, Fixing and reporting.

**Planning:** Define the scope - what is the purpose of the review. Estimate effort and the time frame that the review will be undertaken in. Define roles and review type. Select relevant people. Define entry and exit criteria. Checking entry criteria (mainly used for more formal review types).

**Initiate Review:** Distribute the work products (done by facilitator). Explaining the scope, objectives, process, roles and work products to the participants. Answering any questions raised by the review team.

**Individual Review:** Reviewing all parts of the work product including the source documents. Note potential defects, questions and comments.

**Issues communication and analysis:** Communicate potential defects. Analyse defects. Evaluate and document the required quality criteria (has it been met ?). Evaluate the review results against the exit criteria. 

**Fixing and reporting:** Create defect reports. Fix the defects (typically done y the Author). Record updated status of defects (in formal reviews). Gather metrics e.g. how much time was spent on the review, how many defects found. Check exit criteria.

## Applying Review Techniques

**Ad hoc** - Reviewers given little/no guidance. Little preparation is required. Go through work product sequentially to identify defects. Dependant on review’s skills and may leads to duplicate issues being reported by different reviewers.  

**Checklist-based** – Systematic coverage of typical defects as  effects detected based on checklist. Checklist consists of set of questions based on potential defects, which may be derived from experience. Checklist is sent out at review initiation by facilitator.  

**Scenarios and dry runs** - Reviewers are provided with structured  guidelines on how to read through the work product. Supports reviewers in performing “dry runs” on the work product based on expected usage of the work product (if the work product is  documented in a suitable format such as use cases). These  scenarios provide reviewers with better guidelines on how to identify specific defect types than simple checklist entries. Reviewers should not be constrained to the documented scenarios. 

**Role-Based** – Reviewers evaluate the work product from the perspective of individual stakeholder roles. Typical roles include specific end user types (experienced, inexperienced, senior, child, etc.), and specific roles in the organization (user  administrator, system administrator, performance tester, etc.). 

**Perspective-based** – Similar to role-based. Requires the reviewers to attempt to use the work product under review to  generate the product they would derive from it. For example a tester would attempt to generate draft acceptance tests if performing  a perspective-based reading on a requirements specification to  see if all the necessary information was included. Further, in perspective-based reading, checklists are expected to be used. Most effective Review Technique

