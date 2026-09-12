-- 1. Drop the existing strict unique constraint
ALTER TABLE Documents_tbl 
DROP CONSTRAINT UQ__Document__C5ADBE4D9731AE6E;

-- 2. Apply a Filtered Unique Index that ignores NULL values
CREATE UNIQUE INDEX UQ_Documents_ReferenceNumber 
ON Documents_tbl(ReferenceNumber) 
WHERE ReferenceNumber IS NOT NULL;