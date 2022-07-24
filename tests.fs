require ffl/tst.fs
require factorial.fs

: pass-or-die
  tst-errors @ if
    tst-errors ? ." failures" cr
    s" failed" exception throw
  then ;

t{ ." a dummy test" cr
  false ?false
}t


t{ ." factorial with loop" cr
  0 fact 1 ?s
  1 fact 1 ?s
  2 fact 2 ?s
  3 fact 6 ?s
}t
pass-or-die
bye
