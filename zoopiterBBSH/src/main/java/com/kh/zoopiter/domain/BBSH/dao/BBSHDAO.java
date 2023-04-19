package com.kh.zoopiter.domain.BBSH.dao;

import com.kh.zoopiter.domain.entity.BBSH;

import java.util.List;
import java.util.Optional;

public interface BBSHDAO {

  // 등록
  Long save(BBSH bbsh);

  // 조회
  Optional<BBSH> findById(Long bbshId);

  // 수정
  int update(Long bbshId, BBSH bbsh);

  // 삭제
  int delete(Long bbshId);

  // 목록
  List<BBSH> findAll();
  List<BBSH>  findAll(String category);

  List<BBSH>  findAllPaging(int startRec, int endRec);
  List<BBSH>  findAll(String category,int startRec, int endRec);

  /**
   * 검색
   * @param filterCondition 분류,시작레코드번호,종료레코드번호,검색유형,검색어
   * @return
   */
  List<BBSH>  findAll(BBSHFilterCondition filterCondition);


  // 조회수
  int updateHit(Long bbshId);

  /**
   * 전체건수
   * @return 게시글 전체건수
   */
  int totalCount();
  int totalCount(String petType);
  int totalCount(BBSHFilterCondition filterCondition);

}